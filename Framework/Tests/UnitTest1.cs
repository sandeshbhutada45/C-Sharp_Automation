using Framework.Utils;
using OpenQA.Selenium;

namespace Framework.Tests
{
    public class Tests : Base
    {

        [Test]
        [TestCase("problem_user", "secret_sauce")] //Run Twice for seperate username & password
        [TestCase("error_user", "secret_sauce")]
        public void Test1(String username, String password)
        {
            driver.FindElement(By.Id("user-name")).SendKeys(username);
            driver.FindElement(By.Id("password")).SendKeys(password);
            driver.FindElement(By.Id("login-button")).Click();
            string tit = driver.Title;
            Console.WriteLine(tit);
            Assert.AreEqual("Swag Labs", tit);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IList<IWebElement> links = driver.FindElements(By.TagName("a"));
            Console.WriteLine($"Counts is: {links.Count}");
            for (int i = 0; i < links.Count; i++)
            {
                string link = links[i].GetAttribute("href");
                Console.WriteLine(link);
            }
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}