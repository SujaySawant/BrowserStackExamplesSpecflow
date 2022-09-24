using SpecFlow.Actions.Browserstack;
using TechTalk.SpecFlow;

namespace BrowserStackExamplesSpecflow.StepDefinitions
{
    [Binding]
    public sealed class LocalHooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            List<KeyValuePair<string, string>> bsArgs = new List<KeyValuePair<string, string>>();
            bsArgs.Add(new KeyValuePair<string, string>("key", Environment.GetEnvironmentVariable("BROWSERSTACK_ACCESS_KEY") ?? "BROWSERSTACK_ACCESS_KEY"));
            BrowserstackLocalService.Start(bsArgs);
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            BrowserstackLocalService.Stop();
        }
    }
}