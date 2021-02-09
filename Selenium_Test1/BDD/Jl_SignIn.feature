Feature: Jl_SignIn
	In order to select and purchase items 
	As a potential Johnlewis customer
	I want to be able to register then sign in.

@mytag
Scenario: SignIn
	Given I am on the sign in page
	And I have entered my email something@gmail.com
	And I have entered my password <password>
	When I click the sign in button
	Then then I should be an alert containing an error message "Invalid password"
	Examples:
	| passwords |
	| four		|
	| 1234		|
	| 123pass   |
