Feature: Registration
@mytag
Scenario:User is able to register his account in shareskill application
 Given I am logged in at url "http://192.168.99.100:5000/" to register
 And I am at Home page
 And I click on join
 When I fill the Registration form
 And I click inside checkbox of I agree to terms and conditions
 And I click on join button
 Then I should see message Registration successfull

 
