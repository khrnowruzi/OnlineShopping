Feature: Managing Warehouse Goods
	In order to register an invoice of goods that want to enter the warehouse
	And view the inventory list
	As a warehouse manager
	I want to be able to register an invoice

Background:
	Given I have entered as a warehouse manager

Scenario: Register an IncomingInvoice
	When I register the following IncomingInvoice
		| ProductCode | Count | Date       | InvoiceNumber |
		| S7532       | 10    | 2021/11/05 | 2110          |
	Then I should be able to see the goods entering the warehouse in the list of goods for sell

Scenario: View Inventory List
	Given I have already register of the following IncomingIvoice
		| ProductCode | Count | Date       | InvoiceNumber |
		| S7532       | 10    | 2021/11/05 | 2110          |
	And I have already register of the following SalesInvoice
		| InvoiceNumber | CustomerNumber | Date       | ProductCode | Count | Price |
		| 8820          | Khashayar      | 2021/11/05 | S7532       | 2     | 30000 |
	When I open the page of view inventory list
	Then I should be able to see the following inventory
		| ProductCode | Title   | CategoryId | Count | MinimumInventory | State |
		| S7532       | Samsung | 1          | 8     | 2                | Ready |