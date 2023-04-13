using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PRO_AdacPOM
{
    public class filterloc : Base
    {
        By HoverLink = By.XPath("//nav[@class='gridlock-fluid']/div/div/ul/li[2]");
        By ClickSneaker = By.XPath("//ul[@class='mega-stack']//a[@href = '/collections/men-sneakers']");
        public void MoveToElement()
        {
            Thread.Sleep(5000);
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(HoverLink)).Build().Perform();
            Thread.Sleep(5000);
            clickElement(ClickSneaker);
            Thread.Sleep(5000);
            clickElement(By.XPath("//*[@id=\"boost-pfs-filter-tree2-pf-pt-gender\"]/div/ul/li[2]/button"));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@class=\"boost-pfs-filter-option-range-amount-min\"]")).Click();
            Thread.Sleep(5000);
            Actions actions = new Actions(driver);
            actions.KeyDown(Keys.Control).SendKeys("a").KeyUp(Keys.Control).Perform();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//*[@class=\"boost-pfs-filter-option-range-amount-min\"]")).SendKeys("3000");
            driver.FindElement(By.XPath("//*[@class=\"boost-pfs-filter-option-range-amount-min\"]")).SendKeys(Keys.Tab);
            driver.FindElement(By.XPath("//*[@class=\"boost-pfs-filter-option-range-amount-max\"]")).SendKeys("6000" + Keys.Enter);
            Thread.Sleep(5000);
            clickElement(By.XPath("/html/body/div[3]/div[1]/div[5]/div/div[5]/div[1]/div[1]/div/div/div/div[3]/div[4]/div[2]/div/ul/li[3]"));
            clickElement(By.XPath("/html/body/div[3]/div[1]/div[5]/div/div[5]/div[1]/div[1]/div/div/div/div[3]/div[5]/div[2]/div/ul/li[1]"));
            Thread.Sleep(6000);
            driver.Close();
        }
    }
}