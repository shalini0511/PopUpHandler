using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PopUpHandler
{
    public class Tests:BaseClass.BaseClass
    {
        [Test,Order(0)]
        public void test_alert()
        {
            string button_Xpath = "//button[text()='Click for JS Alert']";
            var expectedAlertText = "I am a JS Alert";
            WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(20));
            driver.Url = test_Url;
            System.Threading.Thread.Sleep(1000);
            IWebElement alertButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(button_Xpath)));

            System.Threading.Thread.Sleep(1000);
            alertButton.Click();

            var alert_Win = driver.SwitchTo().Alert();
            Assert.AreEqual(expectedAlertText, alert_Win.Text);
            System.Threading.Thread.Sleep(1000);
            alert_Win.Accept();

            var clickResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("result")));
            Console.WriteLine(clickResult.Text);

            if(clickResult.Text == "You successfully clicked an alert")
            {
                Console.WriteLine("alert Test Successfull");
            }
        }
        [Test, Order(1)]
        public void test_confirm()
        {
            string button_Css_Selector = "button[onClick='jsConfirm()']";
            var expectedAlertText = "I am a JS Confirm";
            WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(20));
            driver.Url = test_Url;
            System.Threading.Thread.Sleep(1000);
            IWebElement confirmButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(button_Css_Selector)));

            System.Threading.Thread.Sleep(1000);
           confirmButton.Click();

            var confirm_Win = driver.SwitchTo().Alert();
            Assert.AreEqual(expectedAlertText, confirm_Win.Text);
            System.Threading.Thread.Sleep(1000);
            confirm_Win.Accept();

            IWebElement clickResult = driver.FindElement(By.Id("result"));
            Console.WriteLine(clickResult.Text);

            if (clickResult.Text == "You clicked: Ok")
            {
                Console.WriteLine("confirm Test Successfull");
            }
        }
        [Test, Order(2)]
        public void test_dismiss()
        {
            string button_Css_Selector = "button[onClick='jsConfirm()']";
            var expectedAlertText = "I am a JS Confirm";
            WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(20));
            driver.Url = test_Url;
            System.Threading.Thread.Sleep(2000);
            IWebElement confirmButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(button_Css_Selector)));

            System.Threading.Thread.Sleep(2000);
            confirmButton.Click();

            var confirm_Win = driver.SwitchTo().Alert();
            Assert.AreEqual(expectedAlertText, confirm_Win.Text);
            System.Threading.Thread.Sleep(1000);
            confirm_Win.Dismiss();
            System.Threading.Thread.Sleep(9000);
            IWebElement clickResult = driver.FindElement(By.Id("result"));
            Console.WriteLine(clickResult.Text);

            if (clickResult.Text == "You clicked: Cancel")
            {
                Console.WriteLine("Dismiss Test Successfull");
            }
        }
        [Test, Order(3)]
        public void test_SendAlert_text()
        {
            string button_Css_Selector = "button[onClick='jsPrompt()']";
            var expectedAlertText = "I am a JS prompt";
            WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(20));
            driver.Url = test_Url;
            System.Threading.Thread.Sleep(2000);
            IWebElement confirmButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(button_Css_Selector)));

            System.Threading.Thread.Sleep(2000);
            confirmButton.Click();

            var alert_Win = driver.SwitchTo().Alert();
            alert_Win.SendKeys("This is test alert message");
            Assert.AreEqual(expectedAlertText, alert_Win.Text);
            System.Threading.Thread.Sleep(1000);
            alert_Win.Accept();
            System.Threading.Thread.Sleep(9000);
            IWebElement clickResult = driver.FindElement(By.Id("result"));
            Console.WriteLine(clickResult.Text);

            if (clickResult.Text == "You entered: This is test alert message")
            {
                Console.WriteLine("Send Text Alert Test Successfull");
            }
        }

        [Test, Order(4)]
        public void test_CancelAlert_text()
        {
            string button_Css_Selector = "button[onClick='jsPrompt()']";
            var expectedAlertText = "I am a JS prompt";
            WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(20));
            driver.Url = test_Url;
            System.Threading.Thread.Sleep(2000);
            IWebElement confirmButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(button_Css_Selector)));

            System.Threading.Thread.Sleep(2000);
            confirmButton.Click();

            var alert_Win = driver.SwitchTo().Alert();
            Assert.AreEqual(expectedAlertText, alert_Win.Text);
            System.Threading.Thread.Sleep(1000);
            alert_Win.Dismiss();
            System.Threading.Thread.Sleep(9000);
            IWebElement clickResult = driver.FindElement(By.Id("result"));
            Console.WriteLine(clickResult.Text);

            if (clickResult.Text == "You entered: null")
            {
                Console.WriteLine("Cancel Text Alert Test Successfull");
            }
        }



    }
}