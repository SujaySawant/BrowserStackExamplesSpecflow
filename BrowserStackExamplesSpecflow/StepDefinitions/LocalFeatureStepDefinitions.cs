using OpenQA.Selenium;
using SpecFlow.Actions.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BrowserStackExamplesSpecflow.StepDefinitions
{
    [Binding]
    public class LocalFeatureStepDefinitions
    {
        IBrowserInteractions interactions;
        public LocalFeatureStepDefinitions(IBrowserInteractions browserInteractions)
        {
            interactions = browserInteractions;
        }

        [Given(@"I open a localhost page")]
        public void GivenIOpenALocalhostPage()
        {
            interactions.GoToUrl("http://localhost:45691");
        }

        [Then(@"I should see BrowserStack Local")]
        public void ThenIShouldSeeBrowserStackLocal()
        {
            Assert.Contains("BrowserStack Local", interactions.WaitAndReturnElement(By.TagName("body")).Text);
        }
    }
}
