using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SummerQA
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GoToUrl()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.shopmania.ro/");
            driver.Manage().Window.Maximize();
            IWebElement searchBox = driver.FindElement(By.Id("autocomplete_prod"));

            searchBox.SendKeys("telefon");
            searchBox.SendKeys(Keys.Enter);
            Thread.Sleep(4000);

            Assert.IsTrue(driver.FindElementByClassName("label").Displayed);
        }

    }
}
