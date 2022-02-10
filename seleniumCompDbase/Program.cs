using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;

namespace newSelenium
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
            driver.Navigate().GoToUrl("http://computer-database.gatling.io/computers");
           

            By compdbaseSearch  = By.Name("f");
            By computerDbaseSearchButt = By.Id("searchsubmit");
            driver.FindElement(compdbaseSearch).SendKeys("ACE");
            driver.FindElement(computerDbaseSearchButt).Click();

            Console.WriteLine("Search box input ACE typed");

            //open new browser
            addNewComputer ();

            
            
            // driver.Close();
        }

        [Test]
        public static void addNewComputer (){

            driver =  new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://computer-database.gatling.io/computers");

            By addNewComButton = By.Id("add");

            driver.FindElement(addNewComButton).Click();

            Console.WriteLine("Add new computer button clicked");
        }

        [Test]
        public static void addCreateNewComputer (){

            driver =  new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://computer-database.gatling.io/computers/new");

            By addNewComButton = By.ClassName("btn");
            By cancelButton = By.LinkText("Cancel");
            By computerName = By.Name("name");
            By introduced = By.Id("introduced");
            By discontinued = By.Id("discontinued");
            By company = By.Name("company");

            driver.FindElement(computerName).SendKeys("New Computer");
            driver.FindElement(introduced).SendKeys("2022-02-22");
            driver.FindElement(discontinued).SendKeys("2023-03-21");
            driver.FindElement(company).SendKeys("Apple Inc");
            driver.FindElement(addNewComButton).Click();

            Console.WriteLine("Add new computer to dashboard");

            //done
            
        }

        [Test]
        public static void cancelAddNewComp (){

            driver =  new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://computer-database.gatling.io/computers/new");

            By cancelButton = By.LinkText("Cancel");

            driver.FindElement(cancelButton).Click();

            Console.WriteLine("cancel button on add new computer clicked");

            //done
            
        }
    }
}
