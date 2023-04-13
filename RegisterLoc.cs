using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PRO_AdacPOM
{
    public class RegisterLoc: Base
    {

        By logbtn = By.XPath("//ul[@Id ='cart']/li[4]/a");
        By Register = By.XPath("//a[@class='button register-btn']");
        By ename = By.XPath("// input[@name='email']");
        By phone = By.XPath("//input[@type='tel']");
        By sendBtn = By.XPath("//a [@class='button']");



        public void sendSignDetails(string usrnm,string num)
        {
            Thread.Sleep(10000);
            clickElement(logbtn);
            Thread.Sleep(10000);
            clickElement(Register);
            findElement(ename);
            SendKeysMethod(ename, usrnm);
            findElement(phone);
            SendKeysMethod(phone, num);

            Thread.Sleep(2000);
            clickElement(sendBtn);
            Thread.Sleep(10000);
            string errorMsg =  driver.FindElement(By.XPath("//*[@id='form-phone-error']/span")).Text;
           Console.WriteLine("33"+errorMsg);
            Thread.Sleep(10000);
            Assert.AreEqual("You are already registered", errorMsg);

        }
    }
}
