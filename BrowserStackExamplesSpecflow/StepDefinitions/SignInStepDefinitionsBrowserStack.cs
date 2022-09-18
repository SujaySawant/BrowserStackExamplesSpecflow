using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SpecFlow.Actions.Browserstack;
using SpecFlow.Actions.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BrowserStackExamplesSpecflow.StepDefinitions
{
    [Binding]
    public class SignInStepDefinitionsBrowserStack
    {

        IBrowserInteractions interactions;
        public SignInStepDefinitionsBrowserStack(IBrowserInteractions browserInteractions)
        {
            interactions = browserInteractions;
        }

        [Given(@"I open BStackDemo homepage")]
        public void GivenIOpenBStackDemoHomepage()
        {
            interactions.GoToUrl("https://bstackdemo.com");
        }

        [Given(@"I click SignIn link")]
        public void GivenIClickSignInLink()
        {
            interactions.WaitAndReturnElement(By.LinkText("Sign In")).Click();
        }

        [Given(@"I enter the login details")]
        public void GivenIEnterTheLoginDetails()
        {
            interactions.WaitAndReturnElement(By.CssSelector("#username input")).SendKeys("demouser");
            interactions.WaitAndReturnElement(By.XPath("//*[@id='username']/div[2]")).Click();
            interactions.WaitAndReturnElement(By.CssSelector("#password input")).SendKeys("testingisfun");
            interactions.WaitAndReturnElement(By.XPath("//*[@id='password']/div[2]")).Click();
        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            interactions.WaitAndReturnElement(By.Id("login-btn")).Click();
        }

        [Then(@"Profile name should appear")]
        public void ThenProfileNameShouldAppear()
        {
            Assert.Equal("demouser", interactions.WaitAndReturnElement(By.CssSelector("span.username")).Text);
        }
    }
}
