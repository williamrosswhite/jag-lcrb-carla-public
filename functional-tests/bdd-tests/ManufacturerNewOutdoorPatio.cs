﻿using Xunit;
using Xunit.Gherkin.Quick;

/*
Feature: ManufacturerNewOutdoorPatio
    As a logged in business user
    I want to submit a new outdoor patio application for a Manufacturer licence

@manufacturer @winery 
Scenario: Manufacturer New Outdoor Patio (Winery)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Manufacturer Licence
    And I review the account profile for a private corporation
    And I complete the Manufacturer application for a winery
    And I enter the payment information
    And I confirm the payment receipt for a Manufacturer Licence application
    And the application is approved
    And I click on the Licences tab
    And I pay the licensing fee 
    And I click on the Licences tab
    And I click on the link for New Outdoor Patio
    And I request a new outdoor patio application
    And I click on the Submit button
    And the account is deleted
    Then I see the login page
*/

namespace bdd_tests
{
    [FeatureFile("./ManufacturerNewOutdoorPatio.feature")]
    [Collection("Liquor")]
    public sealed class ManufacturerNewOutdoorPatio : TestBase
    {
        [Given(@"I am logged in to the dashboard as a(.*)")]
        public void LogInToDashboard(string businessType)
        {
            NavigateToFeatures();

            CheckFeatureFlagsLiquorTwo();

            CheckFeatureFlagsLicenseeChanges();

            CheckFeatureFlagsSecurityScreening();

            CheckFeatureLEConnections();

            IgnoreSynchronizationFalse();

            CarlaLogin(businessType);
        }
    }
}