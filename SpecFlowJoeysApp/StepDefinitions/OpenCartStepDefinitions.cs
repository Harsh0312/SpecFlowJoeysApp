using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowJoeysApp.StepDefinitions
{
    [Binding]
    public class OpenCartStepDefinitions
    {
        private String searchKeyword;

        private ChromeDriver chromeDriver;

        public OpenCartStepDefinitions() => chromeDriver = new ChromeDriver("C:\\Users\\harsh.singh\\Downloads\\chromedriver_win32");
        [Given(@"Navigate to Pizza Website")]
        public void GivenNavigateToPizzaWebsite()
        {
            chromeDriver.Navigate().GoToUrl("https://azuredeploymentattempt.azurewebsites.net/");
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
        }

        [When(@"I click on Add to cart")]
        public void WhenIClickOnAddToCart()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(15000));
            var Buy_Now_Button = chromeDriver.FindElement(By.XPath("/html/body/div/main/div[2]/div/div/div/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", Buy_Now_Button);
        }

        [Then(@"Cart Page Opens")]
        public void ThenCartPageOpens()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));

        }
    }
}
