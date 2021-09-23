Feature: FirstUserJourney
	As a registred used of souce demo website
	I want to be able to purchase a backpack
	So that I can carry things.

@userjourney @happypath
Scenario: Add Sauce Labs Backpack to the cart
	Given I login
    | Username      | Password     |
    | standard_user | secret_sauce |
	When ADD TO CART button
	Then Cart's Badge goes up