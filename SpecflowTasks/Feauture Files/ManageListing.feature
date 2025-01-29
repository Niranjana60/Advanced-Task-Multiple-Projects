Feature: ManageListing
         As a user i want to edit and delete profile details from Listing management page.

  
@mytag
Scenario: I am able to edit my details from ListingManagement Page
Given I am logged in at url "http://192.168.99.100:5000/"
When i click on sign in
And I enter Login details
And I am at the Profile page
When i click on Manage Listings link
And I click on edit icon from Manage listing table
And i am navigated to  Service lising page
When i edit details in Title text box
And I click on save button from bottom
Then i validate the edited title


@mytag
Scenario:I am able to delete my details from ListingManagement Page
Given I am logged in at url "http://192.168.99.100:5000/"
When i click on sign in
And I enter Login details
And I am at the Profile page
When i click on Manage Listings link
And I click on Delete icon from Manage listing table
And i click on yes button
Then Validate that user details should be deleted.




	
