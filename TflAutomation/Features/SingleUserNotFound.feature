Feature: SingleUserNotFound
	In order to verify a get request for single user not found
    I need to get a request for user not found


@mytag
Scenario: Single User Not Found
	Given I send a single user get request to "https://reqres.in/api/users/23,"
    And I send a get request for single user
    Then I should get user "Not Found" response