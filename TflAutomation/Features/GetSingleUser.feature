Feature: GetSingleUser
	In order to verify a get request
    I need to get the details of a single user

@mytag
Scenario: Get Single User Detail
	Given I send a get request to "https://reqres.in/api/users/2"
    And I send the request to verify the details of the user
    #Then I should get status code "OK"