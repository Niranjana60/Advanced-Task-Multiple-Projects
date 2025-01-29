Feature: LoginPage
         user is able to successfully Login with valid credentials

Scenario Outline:user is able to do login successfully with valid credentials
               Given i am in the loginpage at "http://192.168.99.100:5000/"
                When i click the Sign in Button
                And I enter <Email address> and <Password>
	        When I click the Login button
	        Then I should be logged in successfully

  Examples:
 |    Email address    |Password          |
 |  herrasaad@gmail.com | herrasaad@123   |
		

    
