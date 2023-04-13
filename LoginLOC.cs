using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PRO_AdacPOM
{
    public class LoginLOC : Base
    {

        By logbtn = By.XPath("//ul[@Id ='cart']/li[4]/a");
        By uname = By.CssSelector("#easy-rewards-login > div.email.field-main > input[type=text]");
        By pass = By.CssSelector("#easy-rewards-login > div.password.field-main.main-login > input[type=password]");
        By sigBtn = By.XPath("//input[@value='SIGN IN']");



        public void sendLoginDetails(string usrnm, string pswd)
        {
            Thread.Sleep(10000);
            clickElement(logbtn);
            findElement(uname);
            SendKeysMethod(uname, usrnm);
            findElement(pass);
            SendKeysMethod(pass, pswd);
            Thread.Sleep(2000);
            clickElement(sigBtn);
            
        }
    }
}
