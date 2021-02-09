Feature: Create_User
	In order to shop with John Lewis
	As a potential John Lewis shopper
	I want to create an account in order to sign in.

@mytag
Scenario: Add two numbers
	Given That I don't have an account
	And I select the create an acccount option
	And I add an email <email>
	And I add a password <password>
	When I select create an account
	Then Account created successfully
	Examples:
	| email				  | password |
	|something1@gmail.com |Passw1234 |
	|something2@gmail.com |Passw5678 |
	|something3@gmail.com |Passw9101 |
	|something4@gmail.com |Passw1213 |