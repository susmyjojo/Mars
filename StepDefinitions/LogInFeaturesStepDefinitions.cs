using NUnit.Framework;
using ProjectMarsAutomation.pages;
using ProjectMarsAutomation.Pages;
using ProjectMarsAutomation.utitlities;

namespace ProjectMarsAutomation.StepDefinitions
{
    [Binding]


    public class LogInFeaturesStepDefinitions : CommonDriver

    {

        HomePage HomePageObj;
        LoginPage LoginPageObj;
        [Given(@"user enters valid username '([^']*)' and password '([^']*)'  clicks login button")]
        public void GivenUserEntersValidUsernameAndPasswordClicksLoginButton(string username, string password)
        {
            LoginPageObj = new LoginPage();

            LoginPageObj.LoginActions(username, password);
        }

        [Then(@"User should be redirected to the home page and User should see his name on the topright")]
        public void ThenUserShouldBeRedirectedToTheHomePageAndUserShouldSeeHisNameOnTheTopright()
        {
            HomePageObj = new HomePage();
            string welcomeText = HomePageObj.getWelcomeText();
            Assert.That(welcomeText == "Hi jojo" || welcomeText == "Hi", "Actual welcome text and expected welcome text do not match");
            driver.Close();

        }

        [When(@"User enters invalid username ""([^""]*)"" and/or password ""([^""]*)"" clicks login button")]
        public void WhenUserEntersInvalidUsernameAndOrPasswordClicksLoginButton(string username, string password)
        {
            LoginPageObj = new LoginPage();
            LoginPageObj.LoginActions(username, password);
        }
        [Given(@"User enters invalid username '([^']*)' and/or password '([^']*)' clicks login button")]
        public void GivenUserEntersInvalidUsernameAndOrPasswordClicksLoginButton(string username, string password)
        {
            LoginPageObj = new LoginPage();
            LoginPageObj.InvalidData(username, password);
        }


        [Then(@"User should see an error message")]
        public void ThenUserShouldSeeAnErrorMessage()
        {
            LoginPageObj = new LoginPage();

        }

        [When(@"User attempts to log in with a huge payload body to overflow the system clicks login button")]
        public void WhenUserAttemptsToLogInWithAHugePayloadBodyToOverflowTheSystemClicksLoginButton()
        {
            throw new PendingStepException();
        }


        [Then(@"User should see the validation message")]
        public void ThenUserShouldSeeTheValidationMessage()
        {
            throw new PendingStepException();
        }

        [When(@"User attempts to log in with null username or password clicks login button")]
        public void WhenUserAttemptsToLogInWithNullUsernameOrPasswordClicksLoginButton()
        {
            throw new PendingStepException();
        }


        [Given(@"User enter '([^']*)' and clicks forgot password in the login page")]
        public void GivenUserEnterAndClicksForgotPasswordInTheLoginPage(string username)
        {
            LoginPageObj = new LoginPage();
            LoginPageObj.ForgotPassword(username);
        }

        [When(@"user can enter '([^']*)' and click send verification email")]
        public void WhenUserCanEnterAndClickSendVerificationEmail(string username)
        {
            LoginPageObj = new LoginPage();
            LoginPageObj.SendVerificationEmail(username);
        }

        [Then(@"user able to see a message")]
        public void ThenUserAbleToSeeAMessage()
        {
            LoginPageObj = new LoginPage();
            LoginPageObj.ErrorMessage();

        }
    }
}
