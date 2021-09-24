Feature: Inventory
	As a user
	I want to be able to click the Add to cart button
	So I can add the backpack to my cart.

@mytag
Scenario: Add Sauce Labs Backpack to the cart
	Given I am on the homepage
    And I enter the following credentials
    | Username      | Password     |
    | standard_user | secret_sauce |
    When I enter these credentials
    And I click the login button
	When I click the Backpack's ADD TO CART button
	Then Cart's Badge number goes up by one