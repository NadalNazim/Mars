Feature: Certifications
	Seller wants to add certification to thier profile.


Background: 
	Given seller is logged in and is on certifications page

	Scenario: seller add certification
		Given seller inputs data and save
		| Certificate Name |  | Certfied from |  | Year |
		| Microsoft office |  | Microsoft     |  | 2020 |
		| Adobe XD         |  | Adobe         |  | 2021 |
		|                  |  | Adobe         |  |      |
		Then a message should display


Scenario: seller edits certification
	Given seller is on certifcation page clicks on edit  
	When  seller edits data 
		| Certificate Name             |  | Certfied from |  | Year |
		| Adobe Sign Essentials        |  | Adobe         |  | 20118 |
	And  seller clicks on update
	Then a message appears 


Scenario: seller remove certification
	Given seller is on certifcation page clicks on remove
	Then  a msg is displayed