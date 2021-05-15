Feature: Defining Goods
	In order to define a product
	As a seller
	I want to be able to define a product

Scenario: Define a product
	Given I have entered as a seller account
	When I define the following product
		| Title   | Code  | MinimumInventory | CategoryId |
		| Samsung | S7532 | 2                | 1          |
	Then I should be able to see the product in the list of goods