Feature: FirstUserJourney
	As a registred used of souce demo website
	I want to be able to purchase a backpack
	So that I can carry things.

@userjourney @happypath
Scenario: Add Sauce Labs Backpack to the cart
	Given I am on the homepage
    And I enter the following credentials
    | Username      | Password     |
    | standard_user | secret_sauce |
    When I enter these credentials
    And I click the login button
	When I click the Backpack's ADD TO CART button
	And I click the shopping cart button
	And I click checkout
	And  I enter the follwing checkout information
	| FirstName | LastName    | PostalCode |
	| Sergio    | Pessegueiro | CB1        |
	And I click the continue button
	And I click finish
	Then I should be taken to the checkout completed page.