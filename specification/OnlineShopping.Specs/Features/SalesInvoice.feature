Feature: Sales Invoice Register
	In order to register an invoice of goods sold
	As a sales manager
	I want to be able to register an invoice

Scenario: Register a SalesInvoice
	Given I have entered as a salse manager
	When I register the following SalesInvoice
		| InvoiceNumber | CustomerNumber | Date       | ProductCode | Count | Price |
		| 8820          | Khashayar      | 2021/11/05 | S7532       | 2     | 30000 |
	Then I should be able to see the SalesInvoice in the list of sales invoices
	And I see the product in the SalesInvoice