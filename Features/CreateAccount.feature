﻿Feature: Create Account

Scenario: User is able to craete new account
	Given User is navigated to homepage
	And User clicks on create account button on top navigation bar
	And User able to enter email
	And User able to enter Country
	And User able to enter professional details
	And User able to enter personal details
	Then Verify Create Acoount button
	


	