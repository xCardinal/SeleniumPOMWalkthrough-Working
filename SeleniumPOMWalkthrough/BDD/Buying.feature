Feature: Buying
	As a user
	I want to be able to input my details
	So I can purchase what's in the cart.

@mytag
Scenario: Purchase
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