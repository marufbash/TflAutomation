Feature: UpdateSingleUser
	In order to verify that put request 
    I need to verify that a put request update a single user

@mytag
Scenario: Update Single User
	Given I send a put request to "https://reqres.in/api/users/2"
    And I send a request to verify a single user is updated
    Then I should receive an "OK" response
