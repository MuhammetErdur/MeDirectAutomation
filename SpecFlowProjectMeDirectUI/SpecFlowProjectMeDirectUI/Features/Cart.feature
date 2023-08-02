Feature: Shopping Cart Functionality

Scenario: Verify the product in the cart
  Given I am on the saucedemo.com homepage
  When I click on "Sauce Labs Backpack"
  And I click on the "Add to Cart" button
  Then the product "Sauce Labs Backpack" should be seen in the cart

Scenario: Increase or decrease the quantity of the product in the cart
  Given I am on the saucedemo.com homepage
  When I clcik on the product "Sauce Labs Bike Light"
  And I click on the "Add to Cart" button
  And I navigate to the cart page
  Then the cart should show two products

Scenario: Remove the product from the cart
  Given I am on the saucedemo.com homepage
  When I click on "Sauce Labs Onesie"
  And I click on the "Add to Cart" button
  And I navigate to the cart page
  When I remove "Sauce Labs Onesie" from the cart
  Then the cart should not contain the product "Sauce Labs Onesie"

Scenario: Verify the correct total price in the cart
  Given I am on the saucedemo.com homepage
  When I navigate to the cart page
  And I Click on checkout button
  And I fill out my info
  And I click on continue button  
  Then the cart should display the correct total price for all items
