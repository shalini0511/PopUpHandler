using System;
using System.IO;
using System.Reflection;
using log4net;
using log4net.Repository;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PopUpHandler
{
    public class BaseClass
    {
        public static IWebDriver driver;
        //Get Logger for fully qualified name for type of 'Tests'
        private static readonly ILog log = LogManager.GetLogger(typeof(Tests));

        //Get the default ILoggingRepository
        private static readonly ILoggerRepository repository = log4net.LogManager.GetRepository(Assembly.GetCallingAssembly());


        [SetUp]
        public void start_Browser()
        {
            // Configuring Log4Net
            // BasicConfigurator.Configure();
            // Valid XML file with Log4Net Configurations
            var fileInfo = new FileInfo(@"Log4net.config");

            // Configure default logging repository with Log4Net configurations
            log4net.Config.XmlConfigurator.Configure(repository, fileInfo);
            try
            {
                log.Info("Entering Setup");

                //local selenium webdriver
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                System.Threading.Thread.Sleep(200);
                driver.Url = "https://the-internet.herokuapp.com/javascript_alerts";
                log.Debug("navigating to url");

                log.Info("Exiting setup");

            }


            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
        }
        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }

    }


}

