Feature:Log in Feature


Scenario: 1- user is able to login to the system and view his profile
Given user enters valid username '<username>' and password '<password>'  clicks login button 
Then User should be redirected to the home page and User should see his name on the topright 
Examples:
| username               | password  |
| jojojoseph93@gmail.com | 123456789 |

  

Scenario Outline: 2- User unable to log in with invalid credentials
Given User enters invalid username '<username>' and/or password '<password>' clicks login button
Then User should see an error message

Examples:
| username               | password  |
| jojojoph93@gmail.com | 3456789 |

  Scenario Outline: 3- user uses huge payload of data
When User attempts to log in with a huge payload body to overflow the system clicks login button
Then User should see the validation message 

Scenario Outline: 4- User unable to log in with null username or password
When User attempts to log in with null username or password clicks login button
Then User should see the validation message



Scenario Outline: 5- Verify user is able to reset password 
Given User enter '<username>' and clicks forgot password in the login page
When user can enter '<username>' and click send verification email
Then user able to see a message
Examples:
| username               |
| jojojoseph93@gmail.com |
