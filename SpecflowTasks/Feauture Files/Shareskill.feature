
Feature: ShareSkill
        As a User is  I am able to create New Share skill

   @mytag
   Scenario: user is able to create new share skill 
    Given I am logged in at "http://192.168.99.100:5000/" to log into application.
	And i click sign in from login page
    And I enter My Login Credentials
	And I am at the Profile page now
	When i click shareskill button fronm profile page
	And i enter title from service listing page
    And I enter Description
    And I select a category
    And I select a subcategory
    And I enter Tags
    And I select a service type
    And I select a Location type
    And I Select a start date
    And I Select a day
    And I Select a skill trade
    And I enter skill exchange
    And I Select fromn Active
    And i click on save button
    Then I validate that new share skill is added successfully
