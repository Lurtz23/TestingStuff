using System;
using TechTalk.SpecFlow;
using UdemyTestProject.PageObject;

namespace UdemyTestProject.StepDefinition
{
    [Binding]
    public class SignUpStepDefinitions
    {
        SignUpPage signUpPage;

        public SignUpStepDefinitions()
        {
            signUpPage = new SignUpPage();
        }



        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            signUpPage.NavigateToWebSite();
        }

        [Given(@"I enter my username")]
        public void GivenIEnterMyUsername()
        {
            signUpPage.EnterUsername();
        }

        [Given(@"I enter my e-mail")]
        public void GivenIEnterMyE_Mail()
        {
            signUpPage.EnterEmail();
        }

        [Given(@"I enter my password")]
        public void GivenIEnterMyPassword()
        {
            signUpPage.EnterPassword();
        }

        [When(@"I click on Signup")]
        public void WhenIClickOnSignup()
        {
            signUpPage.ClickSignUpButton();
        }

        [Then(@"I will register successfully")]
        public void ThenIWillRegisterSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
