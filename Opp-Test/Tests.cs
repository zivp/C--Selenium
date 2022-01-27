using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace Opp_Test
{
    [TestFixture]
    public class Tests
    {

        public WebDriver driver;

        [SetUp]
        public void SetUp()
        {
           setup st = new setup(Env.Test.ToString(),Browser.Chrome.ToString());
           driver = st.driver;
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }


        [Test]
        public void Test()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            Assert.True(driver.Title.Contains("Google"));
            Thread.Sleep(3000);
        }
    }
}
