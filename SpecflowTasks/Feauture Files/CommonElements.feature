Feature: CommonElements
As a user i am able to do the functionalties of the application which is common across pages 

   @my tag
   Scenario: I am able to check show less functionality
   Given I am logged in at "http://192.168.99.100:5000/" to log into application
   When i click sign in from login page
   And I enter My Login Credentials
   And I am at the Profile page now
   And I Hover on Notification and click ShowLess
   Then i validate show Less 

   @my tag
   Scenario: User should be able to check Load More functionality
   Given I am logged in at "http://192.168.99.100:5000/" to log into application
   When i click sign in from login page
   And I enter My Login Credentials
   And I am at the Profile page now
   And I Hover on Notification and Click Load More
   Then i validate Load more

    
    @my tag
    Scenario: I am able to Delete Notifications
    Given I am logged in at "http://192.168.99.100:5000/" to log into application
    When i click sign in from login page
    And I enter My Login Credentials
    And I am at the Profile page now
    When I Hover on Notification and Delete Notification
    Then i validate that the notification is Deleted.

    @my tag
    Scenario:I am able to Select All Notifications
    Given I am logged in at "http://192.168.99.100:5000/" to log into application
    When i click sign in from login page
    And I enter My Login Credentials
    And I am at the Profile page now
    And I Hover on Notification and click select all
    Then i validate select all

    @my tag
    Scenario:I am able to UnSelect All Notifications
    Given I am logged in at "http://192.168.99.100:5000/" to log into application
    When i click sign in from login page
    And I enter My Login Credentials
    And I am at the Profile page now
    And I Hover on Notification and click select all
    And i click on Unselect all
    Then i validate Unselect all

    @my tag
    Scenario:I am able to see Notifications Mark as Read
    Given I am logged in at "http://192.168.99.100:5000/" to log into application
    When i click sign in from login page
    And I enter My Login Credentials
    And I am at the Profile page now
    And I Hover on Notification and click see all
    Then i click inside a checkbox near Notification.
    And i click on Mark selection as Read icon
    Then I validate Mark Selection as Read by font size.




  
    
    

    
    
    
   


    
    
