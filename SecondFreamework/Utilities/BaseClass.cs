using AventStack.ExtentReports;
using AventStack.ExtentReports.Configuration;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using SecondFreamework.Variable;
using ServiceStack.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SecondFreamework.Utilities
{
    [Binding]
    public static class BaseClass
    {
        public static ExtentReports extents;
        public static ExtentTest feature;
        public static ExtentTest scenario;
        public static IWebDriver driver;
        [BeforeFeature]
        public static void FeatureBrowser(FeatureContext featureContext)
        {
            feature = extents.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }
        [BeforeScenario]
        public static void LaunchBrowser(ScenarioContext scenarioContext)
        {
            //if (Hooks,config.BrowserType.TOLower() == "Chrome")
            //{
            //    driver = new CHromeDriver();
            //}
            //else if (Hooks.config.BrowserType.ToLower() == "ie")
            //{
            //    driver = new InternetExplorerDriver();
            //}
            scenario = feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://tide.com/en-us");
            driver.Manage().Window.Maximize();
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("One.png", ScreenshotImageFormat.Png);
        //     public static ConfigSetting config;
        //static string configurationpTH = System.IO.Directory.GetParent(@"../../../").FullName + Path.DirectorySeparatorChar + "Configuration/Configsetting.json";
    }
    [BeforeTestRun]
    public static void GenereateReport()
    {
        //config = new ConfigSetting();
        //ConfigurationBuilder builder = new ConfigurationBuilder();
        //builder.AddJsonFile(configsettingpath);
        //IConfigurationRoot configuration = builder.Build();
        //configuration.Bind(config);

        var htmlReport = new ExtentHtmlReporter(@"C:\Users\nandi\source\repos\SecondFreamework\SecondFreamework\\index.html");
        htmlReport.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
        extents = new ExtentReports();
        extents.AttachReporter(htmlReport);
    }
    [AfterTestRun]
    public static void CloseExtentReport()
    {
        extents.Flush();
    }
    [AfterStep]
    public static void InsertReportingSteps(ScenarioContext scenarioContext)
    {
        if (scenarioContext.TestError == null)
        {
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            if (stepType == "Given")
                scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);

            if (stepType == "When")
                scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
            if (stepType == "Then")
                scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
            if (stepType == "And")
                scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);

        }

        if (scenarioContext.TestError != null)
        {
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            if (stepType == "Given")
                scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message);

            if (stepType == "When")
                scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message);
            if (stepType == "Then")
                scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message);
            if (stepType == "And")
                scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message);

        }

    }
    [AfterScenario]
        public static void cleanUp()
        {
            driver.Quit();
        }
    }
}
