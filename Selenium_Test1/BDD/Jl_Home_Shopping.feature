Feature: Jl_Home_Shopping
	As a Johnlewis customer I want to be
	able to select my desired items and add them to a cart
	before or after signing in.

@mytag
Scenario: Home shopping feature
	Given  I'm on the home page
	And I have selected the bedding department
	When I select the items I want 
	Then I will have added those items to the cart