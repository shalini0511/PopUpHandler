using System;
using NUnit.Framework;
using OpenQA.Selenium;
using PopUpHandler.JSAlerts;

namespace PopUpHandler.DoActions
{
    public class DoAction
    {
        
        //Method for Click for Js Alert button
        public static void JsAlertAccept(IWebDriver driver)
        {
            JSAlert obj = new JSAlert(driver);
            var expectedAlertText = "I am a JS Alert";
            //WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(20));
            
            System.Threading.Thread.Sleep(1000);
            IWebElement alertButton = obj.jsAlert;
            //for clicking the click for js alert button
            alertButton.Click();

            var alert_Win = driver.SwitchTo().Alert();
            //validating the text
            Assert.AreEqual(expectedAlertText, alert_Win.Text);
            System.Threading.Thread.Sleep(1000);
            alert_Win.Accept();
            //Checking the result text
            var ClickResult = obj.result;
            Console.WriteLine(ClickResult.Text);

            if (ClickResult.Text == "You successfully clicked an alert")
            {
                Console.WriteLine("alert Test Successfull");
            }

        }
        //Method for Click for Js confirm button and accept
        public static void JsConfirmAccept(IWebDriver driver)
        {
            JSAlert obj1 = new JSAlert(driver);
            var expectedAlertText = "I am a JS Confirm";
            //WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(20));

            System.Threading.Thread.Sleep(1000);
            IWebElement confirmButton = obj1.jsConfirmAccept;
            //for clicking the Click For Js Confirm
            confirmButton.Click();

            var confirm_Win = driver.SwitchTo().Alert();
            //Validating the  popup text
            Assert.AreEqual(expectedAlertText, confirm_Win.Text);
            System.Threading.Thread.Sleep(1000);
            confirm_Win.Accept();

            //Checking the result
            var ClickResult = obj1.result;
            Console.WriteLine(ClickResult.Text);

            if (ClickResult.Text == "You clicked: Ok")
            {
                Console.WriteLine("Confirm Test Successfull");
            }

        }
        //Method for click for Js Confirm and Dismiss
        public static void JsConfirmDismiss(IWebDriver driver)
        {
            JSAlert obj2 = new JSAlert(driver);
            var expectedAlertText = "I am a JS Confirm";
            //WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(20));

            System.Threading.Thread.Sleep(1000);
            IWebElement confirmButton = obj2.jsConfirmDismiss;
            //for clicking Click  for Js Confirm button
            confirmButton.Click();

            var confirm_Win = driver.SwitchTo().Alert();
            //Validating the popup text
            Assert.AreEqual(expectedAlertText, confirm_Win.Text);
            System.Threading.Thread.Sleep(1000);
            confirm_Win.Dismiss();

            //Check the result text
            var ClickResult = obj2.result;
            Console.WriteLine(ClickResult.Text);

            if (ClickResult.Text == "You clicked: Cancel")
            {
                Console.WriteLine("Dismiss Test Successfull");
            }

        }

        //Method for Click for JS Prompt button and Accept
        public static void test_SendAlert_text(IWebDriver driver)
        {
            JSAlert obj3 = new JSAlert(driver);
            var expectedAlertText = "I am a JS prompt";
            //WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(20));

            System.Threading.Thread.Sleep(1000);
            IWebElement confirmButton = obj3.jsPromptAccept;
            //For clicking Click for JS prompt button
            confirmButton.Click();

            var alert_Win = driver.SwitchTo().Alert();

            //Text field with text
            alert_Win.SendKeys("This is test alert message");
            //Validating the popup text
            Assert.AreEqual(expectedAlertText, alert_Win.Text);
            System.Threading.Thread.Sleep(1000);
            alert_Win.Accept();

            //Check the result text
            var ClickResult = obj3.result;
            Console.WriteLine(ClickResult.Text);

            if (ClickResult.Text == "You entered: This is test alert message")
            {
                Console.WriteLine("Send Text Alert Test Successfull");
            }

        }

        //Method for Click for JS Prompt button and Dismiss
        public static void test_CancelAlert_text(IWebDriver driver)
        {
            JSAlert obj4 = new JSAlert(driver);
            var expectedAlertText = "I am a JS prompt";
            //WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(20));

            System.Threading.Thread.Sleep(1000);
            IWebElement confirmButton = obj4.jsPromptAccept;
            //For clicking Click for JS prompt button
            confirmButton.Click();

            var alert_Win = driver.SwitchTo().Alert();
            //Text field without text
            alert_Win.SendKeys(" ");

            //Validating Click for JS Prompt button
            Assert.AreEqual(expectedAlertText, alert_Win.Text);
            System.Threading.Thread.Sleep(1000);
            alert_Win.Dismiss();
            
            //Check for result text
            var ClickResult = obj4.result;
            Console.WriteLine(ClickResult.Text);

            if (ClickResult.Text == "You entered: null")
            {
                Console.WriteLine("null Text Alert Test Successfull");
            }

        }


    }
}
