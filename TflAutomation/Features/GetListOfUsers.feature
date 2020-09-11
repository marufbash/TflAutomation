Feature: GetListOfUsers
	In order to verify a get request for list of users
    I need to get a request for details of list of users

@mytag
Scenario: Get List Of Users
	Given I send a get request list to "https://reqres.in/api/users?page=2"
    And I send a request to verify list of users
    #Then I should get status code "OK"