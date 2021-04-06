﻿using Xunit;
using Xunit.Gherkin.Quick;

/*
Feature: LiquorPrimaryClubTransferLicence
    As a logged in business user
    I want to transfer a Liquor Primary Club Application

@liquorprimaryclub
Scenario: Liquor Primary Club Transfer Licence (Private Corporation)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a LPC Licence
    And I review the account profile for a private corporation
    And I complete the Liquor Primary Club application for a private corporation
    And I click on the Submit button
    And I log in as local government for Parksville
    And I click on the link for Applications for Review
    And I click on the link for Review Application
    And I specify my contact details as the approving authority for liquor primary club
    And I click on the Submit button
    And I log in as a return user
    And I click on the link for Complete Application
    And I click on the Continue to Application button
    And I review the local government response for a liquor primary club licence
    And the application is approved
    And I click on the link for Licences & Authorizations
    And I pay the licensing fee
    And I click on the link for Licences & Authorizations
    And I request a transfer of ownership for Liquor Primary
    And the account is deleted
    Then I see the login page
*/

namespace bdd_tests
{
    [FeatureFile("./LiquorPrimaryClubTransferLicence.feature")]
    [Collection("Liquor")]
    public sealed class LiquorPrimaryClubTransferLicence : TestBase
    {
        [Given(@"I am logged in to the dashboard as a(.*)")]
        public void LogInToDashboard(string businessType)
        {
            NavigateToFeatures();

            CheckFeatureFlagsLiquorTwo();

            CheckFeatureFlagsLicenseeChanges();

            CheckFeatureLEConnections();

            IgnoreSynchronizationFalse();

            CarlaLogin(businessType);
        }
    }
}