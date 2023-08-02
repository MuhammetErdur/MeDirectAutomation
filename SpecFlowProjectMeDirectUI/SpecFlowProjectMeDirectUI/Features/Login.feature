Feature: Login Functionality


Background: 
 * I am on the saucedemo.com login page
 * I enter valid username and password
 * I click on the login button

Scenario: Successful login with valid credentials
  Given I am on the saucedemo.com login page
  When I enter valid username and password
  And I click on the login button
  Then I should be logged in successfully

Scenario: Login failure with invalid credentials
  Given I am on the saucedemo.com login page
  When I enter invalid username and/or password
  And I click on the login button
  Then I should see an error message for invalid credentials
