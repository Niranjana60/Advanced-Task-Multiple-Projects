Feature: Profile
        As a seller I want to add my details in profile.
	I am also able to view my profile details
 
@automated
Scenario Outline: user is able to Add Languages in profile
Given I am logged in at "http://192.168.99.100:5000/" as user "herrasaad@gmail.com" with password "herrasaad@123".
And I am at the Profile page
When I click on Add New button below Language
And I Add <Language> and <LanguageLevel> on Languages tab
And I click on Add button below language tab
Examples:
| Language | LanguageLevel   |
| English  | Fluent          |


@automated
Scenario Outline: I am able to add my skill details
Given I am logged in at "http://192.168.99.100:5000/" as user "herrasaad@gmail.com" with password "herrasaad@123".
And I am at the Profile page
When I click on Skills tab
And I click on Add New button below Skills tab
And I Add <Skill> and <Skill Level> on Skills tab
And I click on Add button
Then Validate that <Skill> and <Skill Level> are added.
Examples:
| Skill | Skill Level |
| C     | Beginner    |
			

@automated
Scenario Outline:I am able to add my Certification details
Given I am logged in at "http://192.168.99.100:5000/" as user "herrasaad@gmail.com" with password "herrasaad@123".
And I am at the Profile page
When I click on Certification Tab
And I click on Add New button below certification tab
And I Add <Certificate or Award> and <Certified From> and <Year> on certification tab
And I click on Add button
Then I Validate that <Certificate or Award> and <Certified From> and <Year>are added
Examples:
| Certificate or Award | Certified From | Year |
|     Barch            |    Adobe       |  2017|

 @automated
 Scenario Outline:I am able to add my Education details 
 Given I am logged in at "http://192.168.99.100:5000/" as user "herrasaad@gmail.com" with password "herrasaad@123".
 And I am at the Profile page
 When I click on Education tab
 And I click on Add New button of Education tab
 And I Add <College Name> and <Country of college> and <Title> and <Degree> and <Year of graduation> on Education tab
 And I click on Add button.
 Then Validate that <College Name> and <Country of college> and <Title> and <Degree> and <Year of graduation> are added
 Examples:
  | College Name | Country of college | Title | Degree | Year of graduation |
  | JTS          | Angola             | MFA   | VLSI   | 2022               |
	

@mytag
Scenario:I am able to add my Description in Profile
Given I am logged in at "http://192.168.99.100:5000/" as user "herrasaad@gmail.com" with password "herrasaad@123".
And I am at the Profile page
When I click on Edit button near Description box
And I enter description in Description box
And I click on save button
Then I validate that Description is saved

@mytag
Scenario:I am able to add my Availability details in Profile.
Given I am logged in at "http://192.168.99.100:5000/" as user "herrasaad@gmail.com" with password "herrasaad@123".
And I am at the Profile page
When i click on Availability drop down list.
And i select "Part time" from availabilty drop down list.
Then i validate that "Part time" is selected from availability drop down list. 

@mytag
Scenario:I am able to add my Hours details in Profile.
Given I am logged in at "http://192.168.99.100:5000/" as user "herrasaad@gmail.com" with password "herrasaad@123".
And I am at the Profile page
When i click on Hours drop down list.
And i select "Less than 30hours a week" from Hours drop down list.
	

 @mytag
 Scenario:I am able to add my Earn Target details in Profile.
 Given I am logged in at "http://192.168.99.100:5000/" as user "herrasaad@gmail.com" with password "herrasaad@123".
 And I am at the Profile page
 When i click on Earn Target drop down list
 And i select "Less than $500 per month" from Target drop down list.
 Then i validate that "Less than $500 per month" is selected from Target drop down list. 


       @mytag
        Scenario: I am able to Send requests 
	Given I am logged in at "http://192.168.99.100:5000/" as user "herrasaad@gmail.com" with password "herrasaad@123".
	And I am at the Profile page
	And I click on serach skill icon
	And i click on  displayed Image
	And i type message in Request box
	And i click on Request button
	And i click on yes from alert pop up
	Then My request is sent.
	
	
	@mytag
        Scenario: User is able to validate the Send requests 
	Given I am logged in at "http://192.168.99.100:5000/" as user "herrasaad@gmail.com" with password "herrasaad@123".
	And I am at the Profile page
	When i hover on Managed requests and click on sent requests
	Then i view and validate the sent requests


	@mytag
        Scenario: User is able to view the Received Requests 
	Given I am logged in at "http://192.168.99.100:5000/" as user "herrasaad@gmail.com" with password "herrasaad@123".
	And I am at the Profile page
	Then I hover on  Manage Requests and click on Received Requests to see the received requests
	

   @mytag
   Scenario: User is able to view and Validate the Received Requests 
   Given I am logged in at "http://192.168.99.100:5000/" as user "herrasaad@gmail.com" with password "herrasaad@123".
   And I am at the Profile page
   Then I hover on  Manage Requests and click on Received Requests to see the received requests
   Then i validate the Received Requests


    @mytag
    Scenario: I am able to send chat messages
    Given I am logged in at "http://192.168.99.100:5000/" as user "herrasaad@gmail.com" with password "herrasaad@123".
    And I am at the Profile page
    And i click on chat link
    And i type message in message box
    And I click on send button
	Then I validate the chat messages send
	
	

    @mytag
    Scenario: User is able to search skills by category
    Given I am logged in at "http://192.168.99.100:5000/" as user "herrasaad@gmail.com" with password "herrasaad@123".
    And I am at the Profile page
    And I click on searchskillsIcon
    And I click on Graphics & Design Category under All categories
    When I click on image of the displayed person
    Then I validate that person is under Graphics & Design Category

    @mytag
    Scenario: User is able to search skills by Subcategory
    Given I am logged in at "http://192.168.99.100:5000/" as user "herrasaad@gmail.com" with password "herrasaad@123".
    And I am at the Profile page
    And I click on searchskillsIcon
    And I click on Graphics & Design Category under All categories
    And I click on LogoDesign subCategory under Graphics & Design
    When I click on image of the displayed person
    Then I validate that person is under LogoDesign subCategory

    @mytag
    Scenario: User is able to search skills by Filter
    Given I am logged in at "http://192.168.99.100:5000/" as user "herrasaad@gmail.com" with password "herrasaad@123".
    And I am at the Profile page
    And I click on searchskillsIcon
    And I click on Online under Filter
    When I click on image of the displayed person
    Then I validate that person displayed is under Location type Online

	





	 


		
