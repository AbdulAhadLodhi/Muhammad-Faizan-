using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO_AdacPOM
{
    public class Base
    {
        public static IWebDriver driver;
        public static IWebDriver SetDriver(string browser)
        {
            if (browser == "Chrome")
            {
                driver = new ChromeDriver();
                driver.Url = "https://www.bata.com.pk/";
                driver.Manage().Window.Maximize();
            }
            return driver;
        }

        #region SendKeys
        public void SendKeysMethod(By locator, string text)
        {
            if (driver.FindElement(locator).GetAttribute("value") != " ")
            {
                driver.FindElement(locator).Clear();
                driver.FindElement(locator).SendKeys(text);
            }
            else
            {
                driver.FindElement(locator).SendKeys(text);
            }
        }
        #endregion

        #region SimpleClick
        public void clickElement(By locator)
        {

            driver.FindElement(locator).Click();

        }
        #endregion

        #region Driver.Close
        public static void Close()
        {

          driver.Close();

        }
        #endregion

        #region Click
        public void clickWebElement(IWebElement element, IWebDriver driver)
        {
            try
            {
                element.Click();
            }
            catch (WebDriverException e)
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].click();", element);
            }
        }
        #endregion

        #region FindElement
        public void findElement(By locator, double timeoutInSeconds = 60)
        {
            if (timeoutInSeconds == 0)
            {
                driver.FindElement(locator);
                clickElement(locator);
            }
            else
            {

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                wait.Until(ExpectedConditions.ElementIsVisible(locator));
                clickElement(locator);
            }


        }
        #endregion

        #region DropDown
        public void dropdown(By loc, string type, string value)
        {
            IWebElement element = driver.FindElement(loc);
            SelectElement drpdwn = new SelectElement(element);
            if (type == "value")
            {
                drpdwn.SelectByValue(value);
                element.Click();
            }

            else if (type == "text")
            {
                drpdwn.SelectByText(value);
                element.Click();
            }

            else if (type == "index")
            {
                drpdwn.SelectByIndex(Convert.ToInt32(value));
                element.Click();
            }
        }
        #endregion

    }

}

