using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PopUpHandler
{
    public class BaseClass
    {
        public IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {

            driver = new ChromeDriver();
            driver.Url = "https://the-internet.herokuapp.com/javascript_alerts";
             //To maximize window 
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(300);
        }

        [TearDown]
        public void close_Browser()
        {
            //Used to close the opened session
            driver.Quit();
        }

    }
}
