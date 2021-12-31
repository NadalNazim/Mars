Feature: Education
	Seller wants to add education background.

Background: 
	Given Seller is logged in and is on education page

	Scenario: seller adds education
		Given seller inputs education data and save
		| College Name |  | Country     |  | Title  |  | Degree        |  | Year |
		| Unitec       |  | New Zealand |  | B.Tech |  | Diploma       |  | 2016 |
		| JHU          |  | India       |  | MCA    |  | Certification |  | 2020 |
		|              |  | New Zealand |  |        |  | Diploma       |  |      |   
		Then a message should display


Scenario: seller edits education
	Given seller is on education page clicks on edit option 
	When  seller edits data 
	| College Name |  | Country     |  | Title  |  | Degree         |  | Year  |
	| Unitec       |  | New Zealand |  | M.B.A  |  | Certification  |  | 2017  |
	And  seller clicks on update
	Then a message appears 


Scenario: seller remove education
	Given seller is on education page clicks on remove
	Then a msg is displayed


