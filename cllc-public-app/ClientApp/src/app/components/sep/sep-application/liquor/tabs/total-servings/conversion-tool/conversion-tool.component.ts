import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-conversion-tool',
  templateUrl: './conversion-tool.component.html',
  styleUrls: ['./conversion-tool.component.scss']
})
export class ConversionToolComponent implements OnInit {
  @Input() toolType: 'beer' | 'wine' | 'spirits';
  LiquorTypes = LiquorTypes;

  numberOfStandardDrinks: number;
  pricePerStandardDrink: number;
  form: FormGroup;

  constructor(private fb: FormBuilder) { }

  ngOnInit(): void {
    this.form = this.fb.group({
      sizeOfTasting: [''],
      numberOfTastings: [''],
      pricePerTastingDrink: ['']
    });

    if (this.toolType === 'spirits') {
      this.form.get('sizeOfTasting').patchValue(0.5);
    }

    this.form.valueChanges.subscribe(() => {
      const tastingSize = this.form.get('sizeOfTasting').value;
      const numberOfTastings = this.form.get('numberOfTastings').value;
      const pricePerTastingDrink = this.form.get('pricePerTastingDrink').value;
      const standardDrinkSize = LiquorTypes[this.toolType].standardDrinkSizeOz;

      if (tastingSize && numberOfTastings) {
        this.numberOfStandardDrinks = Math.ceil((tastingSize * numberOfTastings) / standardDrinkSize)
      }

      if (pricePerTastingDrink) {
        if(this.toolType === 'beer') {
          this.pricePerStandardDrink = pricePerTastingDrink * (12/tastingSize);
        }
        if(this.toolType === 'wine') {
          this.pricePerStandardDrink = pricePerTastingDrink * (5/tastingSize);
        }
        if(this.toolType === 'spirits') {
          this.pricePerStandardDrink = pricePerTastingDrink * (1.5/tastingSize);
        }


      }
    });
  }

  resetValues() {
    this.pricePerStandardDrink = null;
    this.numberOfStandardDrinks = null;
    this.form.get('numberOfTastings')?.reset()
    this.form.get('pricePerTastingDrink')?.reset()
    if (this.toolType !== 'spirits') {
      this.form.get('sizeOfTasting')?.reset();
    }
  }

}

const LiquorTypes = {
  beer: {
    title: 'Beer, Ciders and Coolers',
    standardDrinkSizeOz: 12,
    maxTastingSize: '4',
    maxPrice: '$5.00'
  },
  wine: {
    title: 'Wine',
    standardDrinkSizeOz: 5,
    maxTastingSize: '2',
    maxPrice: '$7.00'
  },
  spirits: {
    title: 'Spirits',
    standardDrinkSizeOz: 1.5,
    maxPrice: '$5.00'
  },
}
