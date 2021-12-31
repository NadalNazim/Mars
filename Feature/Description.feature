Feature: Description
	Seller wants to add description to thier profile.

Background: 

 Given Seller is logged in and is on profile page

	Scenario: seller add their description 
		Given seller enters description into the description box
		| Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
		| My name is Nadal Nazim. I’m the QA intern at MVP studio. |
		| My name is Nadal. I’m the QA intern at MVP studio. I’ve created over a dozen apps designed to streamline sales and marketing activities for busy professionals. I see myself as a relentless problem-solver, and I’m always looking for a new challenge. I’ve recently gotten interested in recreational boating and noticed that the sales professionals at Dockside Boats don’t seem to have a streamlined system for tracking their sales. I’d love to discuss your needs in this area and find out if you’re interested in participating in beta testing for a new sales app I’m testing. Also coding in c# is impor |
		Then  a successful message should be displayed


Scenario: seller edits description
	Given seller clicks on outline write icon
	When  seller edits the description and saves the data
	| Description |
	| My name is Nadal. I’m the QA intern at MVP studio. |
	Then  a message should appear 


Scenario: seller tries to enter description starting with a special character
	Given seller clicks on outline write icon
	When  seller inputs the description and tries to saves the data
	| Description |
	| /My name is Nadal. I’m the QA intern at MVP studio. |
	Then a error message display


