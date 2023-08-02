Feature: Filtering Product by Name and Price

Scenario: Filter a product by name
  Given I am on the saucedemo.com homepage
  When I click on filter box
  And I click Name (A to Z)
  Then I should see the products in correct order