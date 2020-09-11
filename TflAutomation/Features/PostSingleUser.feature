Feature: PostSingleUser
	In order to verify a post request
    I need to create a single user

@mytag
Scenario: Post Single User
	Given I send a post request to https://reqres.in/api/users/2
    And I send post request to verify the user
    When The reply is received
    Then I should get status code "Created"