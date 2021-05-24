Feature: Managing Warehouse Products
	In order to register an invoice of products that want to enter the warehouse
	And view the inventory list
	As a warehouse manager
	I want to be able to register an invoice

Background:
	Given I have entered as a warehouse manager

Scenario: Register an IncomingInvoice
	When I register the following IncomingInvoice
		| Date  | InvoiceNumber |
		| Today | 2110          |
	And I have one product in invoice with the following info
		| ProductCode | Count | Price |
		| S7532       | 10    | 10000 |
	Then I should be able to see the product in the list of products for sell

Scenario: View Inventory List
	Given I have already register of the following IncomingInvoice
		| ProductCode | Count | Date  | InvoiceNumber |
		| S7532       | 10    | Today | 2110          |
	And I have already register of the following SalesInvoice
		| InvoiceNumber | CustomerNumber | Date  | ProductCode | Count | Price |
		| 8820          | Khashayar      | Today | S7532       | 2     | 30000 |
	When I open the page of view inventory list
	Then I should be able to see the following inventory
		| ProductCode | Title   | CategoryId | Count | MinimumInventory | State |
		| S7532       | Samsung | 1          | 8     | 2                | Ready |