Feature: Languages
	Seller wants to add Languages to their profile


Background: 
	Given  seller is logged into profile 

Scenario: Seller ads a new language
	Given seller enters language name and selects language level
	| Add Language |  | Choose Language Level |
	| Japanese     |  | Conversational        |
	| English      |  | Fluent                |
	| Hindi		   |  | Native/Bilingual      |
	| Maori        |  | Basic                 |
	Then   a  message should be displayed


Scenario: Seller cancels to add new language 
	Given seller is logged-in and is on profile page
	And   seller clicks on "Add New" button
	When  seller clicks on "Cancel" button 
	Then  add language field should be hidden


Scenario: Seller edits a saved language 
	Given seller has already saved Japanese language
	And   seller clicks on  write icon
	When  seller enters language name 
	| Add Language |  
	| Chinese      | 
	Then  seller clicks on "Update" button new data should be updated
	And   a message displays


Scenario: Seller cancels to update language 
	Given seller has already saved Chinese language
	And   seller clicks on  write icon
	When  seller clicks on "Cancel" button 
	Then  update language field should be hidden


Scenario: Seller deletes a saved language 
	Given seller has already saved "Maori" language
	When  seller clicks on remove icon language should be deleted
	Then  a successfull message should be displayed


Scenario: Seller tries to save empty new language
	Given seller is logged-in and is on profile page
	And   seller clicks on "Add New" button
	When  seller dose not enters language name and selects language level
	| Add Language |  | Choose Language Level |
	|			   |  |						  |
	Then  seller clicks on "Add" button
	And   an error message should be displayed


Scenario: Seller tries to add duplicate new language
	Given seller has already saved "Japanese" language
	And   seller clicks on "Add New" button
	When  seller enters language name and selects language level
	| Add Language |  | Choose Language Level |
	| Maori        |  | Basic                 |
	Then  seller clicks on "Add" button
	And   an error message should be displayed


