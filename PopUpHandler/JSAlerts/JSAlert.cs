using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PopUpHandler.JSAlerts
{
    public class JSAlert
    {
        public JSAlert(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        //using FindsBy locating the element
        //Click For JS Alert button
        [FindsBy(How = How.XPath, Using = "//button[text()='Click for JS Alert']")]
        [CacheLookup]
        public IWebElement jsAlert;

        [FindsBy(How = How.Id, Using = "result")]
        [CacheLookup]
        public IWebElement result;

        //Click for JS Confirm
        [FindsBy(How = How.CssSelector, Using = "button[onClick='jsConfirm()']")]
        [CacheLookup]
        public IWebElement jsConfirmAccept;

        [FindsBy(How = How.CssSelector, Using = "button[onClick='jsConfirm()']")]
        [CacheLookup]
        public IWebElement jsConfirmDismiss;

        //Click for JS Prompt
        [FindsBy(How = How.CssSelector, Using = "button[onClick='jsPrompt()']")]
        [CacheLookup]
        public IWebElement jsPromptAccept;

        [FindsBy(How = How.CssSelector, Using = "button[onClick='jsPrompt()']")]
        [CacheLookup]
        public IWebElement jsPromptDismiss;

    }
}
