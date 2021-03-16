﻿Feature: CrsApplication
    As a logged in business user
    I want to submit a CRS Application for different business types

@cannabis @privatecorporation @crsapp
Scenario: CRS Application (Private Corporation)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for a Cannabis Retail Store
    # And I complete the eligibility disclosure
    And I review the account profile for a private corporation
    And I complete the Cannabis Retail Store application for a private corporation
    And I click on the Submit button
    And I enter the payment information
    And I confirm the payment receipt for a Cannabis Retail Store application
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the account is deleted
    Then I see the login page

@cannabis @society @crsapp
Scenario: CRS Application (Society)
    Given I am logged in to the dashboard as a society
    And I click on the Start Application button for a Cannabis Retail Store
    # And I complete the eligibility disclosure
    And I review the account profile for a society
    And I complete the Cannabis Retail Store application for a society
    And I click on the Submit button
    And I enter the payment information
    And I confirm the payment receipt for a Cannabis Retail Store application
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the account is deleted
    Then I see the login page

@cannabis @partnership @crsapp
Scenario: CRS Application (Partnership)
    Given I am logged in to the dashboard as a partnership
    And I click on the Start Application button for a Cannabis Retail Store
    # And I complete the eligibility disclosure
    And I review the account profile for a partnership
    And I complete the Cannabis Retail Store application for a partnership
    And I click on the Submit button
    And I enter the payment information
    And I confirm the payment receipt for a Cannabis Retail Store application
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the account is deleted
    Then I see the login page

@cannabis @soleproprietorship @crsapp
Scenario: CRS Application (Sole Proprietorship)
    Given I am logged in to the dashboard as a sole proprietorship
    And I click on the Start Application button for a Cannabis Retail Store
    # And I complete the eligibility disclosure
    And I review the account profile for a sole proprietorship
    And I complete the Cannabis Retail Store application for a sole proprietorship
    And I click on the Submit button
    And I enter the payment information
    And I confirm the payment receipt for a Cannabis Retail Store application
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the account is deleted
    Then I see the login page