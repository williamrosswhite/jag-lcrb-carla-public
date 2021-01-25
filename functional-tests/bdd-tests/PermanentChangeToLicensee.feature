﻿Feature: PermanentChangeToLicensee
    As a logged in business user
    I want to submit a licensee changes for different licence types

@cannabis @licenseechanges
Scenario: DEV CRS Licensee Changes (Private Corporation)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Cannabis Retail Store
    And I complete the eligibility disclosure
    And I review the account profile for a private corporation
    And I complete the Cannabis Retail Store application for a private corporation
    And I click on the Submit button
    And I enter the payment information
    And the application is approved
    And I click on the Dashboard tab
    And I click on the button for Submit a Change
    And I complete the Permanent Change to a Licensee application for a CRS application
    And the account is deleted
    Then I see the login page

@catering @licenseechanges
Scenario: DEV Catering Licensee Changes (Private Corporation)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for Catering
    And I review the account profile for a private corporation
    And I complete the Catering application
    And I click on the Submit button
    And I enter the payment information
    And the application is approved
    And I click on the Dashboard tab
    And I click on the button for Submit a Change
    And I complete the Permanent Change to a Licensee application for a Catering application
    And the account is deleted
    Then I see the login page