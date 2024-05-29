using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace Selenium_C_
{
    public class Locators
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.saucedemo.com/";
        }

        [Test]
        public void Test1()
        {
            driver.FindElement(By.Id("user-name")).SendKeys("problem_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();
            String tit = driver.Title;
            Console.WriteLine(tit);
            Assert.AreEqual("Swag Labs", tit);
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);
            IList<IWebElement> links = driver.FindElements(By.TagName("a"));
            Console.WriteLine($"Counts is: {links.Count}");
            for (int i = 0; i < links.Count; i++)
            {
                String link = links[i].GetAttribute("href");
                Console.WriteLine(link);
            }
            driver.FindElement(By.XPath("//*[@id=\"page_wrapper\"]/footer/ul/li[2]/a")).Click();
            int count=driver.WindowHandles.Count;
            Console.WriteLine($"Windows is: {count}");
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }

    }
}
