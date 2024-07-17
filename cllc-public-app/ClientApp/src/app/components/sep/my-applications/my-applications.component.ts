import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ActivatedRoute, Router } from '@angular/router';
import { AppState } from '@app/app-state/models/app-state';
import { ApplicationCancellationDialogComponent } from '@components/dashboard/applications-and-licences/applications-and-licences.component';
import { SepApplication } from '@models/sep-application.model';
import { User } from '@models/user.model';
import { Store } from '@ngrx/store';
import { IndexedDBService } from '@services/indexed-db.service';
import { StarterChecklistComponent } from '../starter-checklist/starter-checklist.component';
import { faEdit } from '@fortawesome/free-solid-svg-icons';
import { SEP_APPLICATION_STEPS } from '../sep-application/sep-application.component';
import { SepApplicationSummary } from '@models/sep-application-summary.model';

@Component({
  selector: 'app-my-applications',
  templateUrl: './my-applications.component.html',
  styleUrls: ['./my-applications.component.scss']
})
export class MyApplicationsComponent implements OnInit {
  applications: any[];
  displayedColumns = ['status', 'info', 'actions'];
  currentUser: User;
  submittedApplication: SepApplicationSummary[];

  constructor(private store: Store<AppState>,
    private db: IndexedDBService,
    private route: ActivatedRoute,
    private router: Router,
    private dialog: MatDialog,
    ) {
    store.select(state => state.currentUserState.currentUser)
      .subscribe((user: User) => {
        this.currentUser = user;
      });
  }

  async ngOnInit() {    
    localStorage.setItem('isPacificTimeZone', 'true');
    await this.getApplications();
  }

  async getApplications() {
    let applications = await this.db.applications.toArray();
    applications = applications.filter(app => app.eventStatus === 'Draft');
    applications = applications.sort((a, b) => {
      const dateA = new Date(a.dateCreated).getTime();
      const dateB = new Date(b.dateCreated).getTime();
      return dateB - dateA;
    });
    this.applications = applications;
  }

  startApplication() {
    const dialogConfig = {
      disableClose: true,
      autoFocus: true,
      width: '600px',
      data: {
        showStartApp: true
      }
    };

    // open dialog, get reference and process returned data from dialog
    const dialogRef = this.dialog.open(StarterChecklistComponent, dialogConfig);
    dialogRef.afterClosed()
      .subscribe((startApplication: boolean) => {
        if (startApplication) {
          const data = {
            dateCreated: new Date()
          } as SepApplication;
          this.db.saveSepApplication(data)
            .then(localId => {
              this.router.navigateByUrl(`/sep/application/${localId}/applicant`);
            });
        }
      });
  }

  /**
   *
   * @param localId
   * @param establishmentName
   * @param applicationName
   */
  cancelApplication(localId: number, establishmentName: string, applicationName: string) {
    const dialogConfig = {
      disableClose: true,
      autoFocus: true,
      width: '400px',
      height: '200px',
      data: {
        establishmentName: establishmentName,
        applicationName: applicationName
      }
    };
    // open dialog, get reference and process returned data from dialog
    const dialogRef = this.dialog.open(ApplicationCancellationDialogComponent, dialogConfig);
    dialogRef.afterClosed()
      .subscribe(async (cancelApplication) => {
        if (cancelApplication) {
          this.db.deleteSepApplication(localId);
          await this.getApplications();
        }
      });

  }


  async cloneApplication(app: SepApplication) {
    const clone = { ...app };
    // clear dynamics IDs
    clone.id = undefined;
    clone.localId = undefined;
    if (clone?.eventLocations?.length > 0) {
      clone.eventLocations.forEach(loc => {
        loc.id = undefined;
        if (loc?.serviceAreas?.length > 0) {
          loc.serviceAreas.forEach(area => {
            area.id = undefined;
          });
        }
        if (loc?.eventDates?.length > 0) {
          loc.eventDates.forEach(ed => {
            ed.id = undefined;
          });
        }
      });
    }
    const localId = await this.db.saveSepApplication({
      ...clone,
      dateAgreedToTsAndCs: undefined,
      isAgreeTsAndCs: false,
      dateCreated: new Date()
    } as SepApplication);
    this.router.navigateByUrl(`/sep/application/${localId}/applicant`);
  }


}
