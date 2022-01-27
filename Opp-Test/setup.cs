using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using WebDriverManager.DriverConfigs.Impl;

namespace Opp_Test
{


    public class setup
    {
        public string browser { get; set; }
        public string env { get; set; }
        public WebDriver driver { get; set; }

        public setup(string env, string browser)
        {
            this.browser = browser;
            this.env = env;
            this.driver = getDriver(browser);
        }

        protected WebDriver getDriver(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    return new ChromeDriver();
                case "IE":
                    new WebDriverManager.DriverManager().SetUpDriver(new InternetExplorerConfig());
                    return new InternetExplorerDriver();
                case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    return new FirefoxDriver();
                default:
                    throw new Exception("error ! new driver is not init ...");
            }

        }
    }

    enum Browser
    {
        Chrome,
        IE,
        Firefox

    }
    enum Env
    {
        Test,
        Prod,
        Stage

    }
}


   