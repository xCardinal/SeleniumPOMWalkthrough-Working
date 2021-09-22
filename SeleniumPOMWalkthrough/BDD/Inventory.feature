Feature: Inventory
	Simple calculator for adding two numbers

@mytag
Scenario: Add Sauce Labs Backpack to the cart
	Given I login successfully with the credentials
    | Username      | Password     |
    | standard_user | secret_sauce |
	When I click the Backpack's ADD TO CART button
	Then Cart's Badge number goes up by one