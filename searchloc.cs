using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PRO_AdacPOM
{
    internal class searchloc :Base
    {
        By Search = By.XPath("//*[@id=\'boost-pfs-search-box-2\']");


        public void Searchkey(string Searchkey)
        {

            driver.FindElement(Search).SendKeys(Searchkey);
            Thread.Sleep(2000);
            driver.FindElement(Search).Submit();




        }
    }
}
