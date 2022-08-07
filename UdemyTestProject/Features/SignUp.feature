Feature: SignUp

Signing up to the website

@tag1
Scenario: Valid SignUp

	Given I navigate to the website
	And I enter my username
	And I enter my e-mail
	And I enter my password
	When I click on Signup
	Then I will register successfully
