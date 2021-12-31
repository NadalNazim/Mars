Feature: Skills
	Seller wants to add and display skills.


Background: 

	Given Seller is logged-in and is in skills section

	Scenario: Seller adds a new skill
		Given seller clicks on Add New button
		When  seller inputs skill name and selects skill level
		| Add Skill |  
		| C# Coding |  		
		Then  seller clicks on Add button data should be saved
		And   a successfull message should be displayed


	Scenario: Seller duplicate a skill
		Given seller clicks on add button
		When  seller enters skill name
		| Add Skill |  
		| C# Coding |  		
		Then  seller clicks on Add button 
		And   an error message should display


	Scenario: Seller edit a skill
		Given seller clicks on edit icon
		When  seller edits skill name and skill level
		| Add Skill |  
		| Testing   |  		
		Then  seller clicks on update button 
		And   a successful message should appear


	Scenario: Seller removes a skill
		Given seller clicks on remove icon	
		Then  a message should be displayed