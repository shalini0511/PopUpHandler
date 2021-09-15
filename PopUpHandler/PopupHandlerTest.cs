/*summary :Testing Alert Popups
  Author: V SHALINI
  Date  : 15-09-21
*/

using NUnit.Framework;


namespace PopUpHandler
{
    public class Tests:BaseClass
    {
        [Test]    
        public void TestForJsAlertAccept()
        {
            //Js Alert Accept
            DoActions.DoAction.JsAlertAccept(driver);
            //Js Confirm Accept mehtod
            DoActions.DoAction.JsConfirmAccept(driver);
            //Js confirm Dismiss method
            DoActions.DoAction.JsConfirmDismiss(driver);
            //Js Send text alert accept method
            DoActions.DoAction.test_SendAlert_text(driver);
            //Js send without text alert dismiss method
            DoActions.DoAction.test_CancelAlert_text(driver);


        }

    }
}