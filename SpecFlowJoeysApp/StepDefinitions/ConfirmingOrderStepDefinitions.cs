using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowJoeysApp.StepDefinitions
{
    [Binding]
    public class ConfirmingOrderStepDefinitions
    {
        private String searchKeyword;

        private ChromeDriver chromeDriver;

        public ConfirmingOrderStepDefinitions() => chromeDriver = new ChromeDriver("C:\\Users\\harsh.singh\\Downloads\\chromedriver_win32");
        [Given(@"Navigate to the Website")]
        public void GivenNavigateToTheWebsite()
        {
            chromeDriver.Navigate().GoToUrl("https://azuredeploymentattempt.azurewebsites.net/");
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
        }

        [When(@"Click on Buy Now of Margerita")]
        public void WhenClickOnBuyNowOfMargerita()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(15000));
            var Buy_Now_Button = chromeDriver.FindElement(By.XPath("/html/body/div/main/div/div/div/div/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", Buy_Now_Button);
        }

        [When(@"Click on Continue Shopping")]
        public void WhenClickOnContinueShopping()
        {
            var Continue_Shopping_Button = chromeDriver.FindElement(By.XPath("/html/body/div/main/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", Continue_Shopping_Button);
        }

        [Then(@"Home Page Opens")]
        public void ThenHomePageOpens()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));

        }

        [When(@"Click on Buy Now of Corn")]
        public void WhenClickOnBuyNowOfCorn()
        {
            var Buy_Now_Button = chromeDriver.FindElement(By.XPath("/html/body/div/main/div[2]/div/div/div/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", Buy_Now_Button);
        }

        [Then(@"Cart Page Opens Again")]
        public void ThenCartPageOpensAgain()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));

        }

        [When(@"Click on CheckOut")]
        public void WhenClickOnCheckOut()
        {
            var Checkout_button = chromeDriver.FindElement(By.XPath("/html/body/div/main/a[2]"));
            chromeDriver.ExecuteScript("arguments[0].click();", Checkout_button);

        }

        [Then(@"Order Confirmation Page Opens")]
        public void ThenOrderConfirmationPageOpens()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));

        }
    }
}
