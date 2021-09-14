using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PopUpHandler.BaseClass
{
    public class BaseClass
    {
        public string test_Url = "https://the-internet.herokuapp.com/javascript_alerts";
        public IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(300);
        }

        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }

    }
}

