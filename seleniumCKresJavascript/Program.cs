using System;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;

namespace seleniumCKresJavascript
{
    class Program
    {

        public static IWebDriver driver;

        [Test]
        public static void Main()
        {

            System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"G:\\install\\selenium driver chrome\\chromedriver.exe");
            driver =  new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");
           

            By jsAlertButton  = By.XPath(".//button[text()='Click for JS Alert']");

            driver.FindElement(jsAlertButton).Click();
            Console.WriteLine("Button Click for JS Alert Clicked");
            Thread.Sleep(1000);

            IAlert simpleAlert = driver.SwitchTo().Alert();
            Thread.Sleep(1000);
            simpleAlert.Accept();
            Console.WriteLine("ok button on alert Clicked");
        }

        [Test]
        public static void ClickJsConfirm()
        {

            driver =  new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");
           

            By jsConfirmButton  = By.XPath(".//button[text()='Click for JS Confirm']");

            driver.FindElement(jsConfirmButton).Click();
            Console.WriteLine("Button Click for JS Confirm Clicked");

            Thread.Sleep(1000);

            IAlert okAlert = driver.SwitchTo().Alert();
            Thread.Sleep(1000);
            okAlert.Accept();
            Console.WriteLine("ok button on Confirm Clicked");

            // code to click cancel
            // IAlert cancelAlert = driver.SwitchTo().Alert();
            // cancelAlert.Dismiss();
            // Console.WriteLine("cancel button on Confirm Clicked");
        }

        [Test]
        public static void ClickJsPrompt()
        {

             driver =  new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");
           

            By jsPromptButton  = By.XPath(".//button[text()='Click for JS Prompt']");

            driver.FindElement(jsPromptButton).Click();
            Console.WriteLine("Button Click for JS Prompt Clicked");

            Thread.Sleep(1000);

            IAlert okAlert = driver.SwitchTo().Alert();
            Thread.Sleep(1000);
            okAlert.SendKeys("Accepting the Prompt");
            Thread.Sleep(1000);
            okAlert.Accept();
            Console.WriteLine("ok button on alert Clicked");


            // code to click cancel
            // IAlert cancelAlert = driver.SwitchTo().Alert();
            // cancelAlert.Dismiss();
            // Console.WriteLine("cancel button on Prompt Clicked");
        }
        
    }
}
