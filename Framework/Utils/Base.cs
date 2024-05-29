using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace Framework.Utils
{
    public class Base
    {
        public IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            String Bname = ConfigurationManager.AppSettings["browser"];
            InitBrowser(Bname);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.saucedemo.com/";
        }

        public void InitBrowser(String browserName)
        {
            switch (browserName)
            {
                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;

                case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;

                case "Edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    driver = new EdgeDriver();
                    break;




            }

        }

    }
}
