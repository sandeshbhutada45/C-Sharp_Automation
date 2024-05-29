using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace Selenium_C_
{
    public class SeleniumFirst
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
           new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://www.google.com";
            Console.WriteLine(driver.Url);
            Console.WriteLine(driver.Title);   

        }
        [TearDown]
        public void tearDownBrowser()
        {
            driver.Close();
        }

    }
}
