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
            bsArgs.Add(new KeyValuePair<string, string>("key", Environment.GetEnvironmentVariable("BROWSERSTACK_ACCESS_KEY")));
            BrowserstackLocalService.Start(bsArgs);
            Console.WriteLine("Started Local Connection");
            //dotnet test --filter Category=local
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            BrowserstackLocalService.Stop();
            Console.WriteLine("Stopped Local Connection");
        }
    }
}