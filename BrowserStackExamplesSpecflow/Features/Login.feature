Feature: Login

Login to BStackDemo website

@login
Scenario: BStackDemo Login
	Given I open BStackDemo homepage
	And I click SignIn link
	And I enter the login details
	When I click login button
	Then Profile name should appear
