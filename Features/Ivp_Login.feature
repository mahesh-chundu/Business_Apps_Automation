Feature: Ivp_Login

As a user
I want to log into the application
So that I can access my account

@Login
Scenario: Successful login to IVP through Okta Preview
	Given I am on the login page
	When I enter valid credentials
	Then I click on the login button
@CreateAProgram
Scenario: Click on Create a Program Button
	Given I am on the Dashboard Page
	When The Add New Program Button is avaliable
	Then I click on the Add New Program Button

