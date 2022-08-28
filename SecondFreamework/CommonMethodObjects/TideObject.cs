using OpenQA.Selenium.DevTools;
using OpenQA.Selenium;
using SecondFreamework.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondFreamework.CommonMethodObjects
{
    public class TideObject
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void VerifyHomePage()
        {
            IWebElement home;
            bool display = true;
            home = BaseClass.driver.FindElement(By.XPath("//span[.='Part of the P&G Family']"));
            log.Info("SuccessfullyVerified");
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile("two.png", ScreenshotImageFormat.Png);
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            display = home.Displayed;
        }
        public void Product()
        {
            IWebElement product = BaseClass.driver.FindElement(By.XPath("//*[@id=\"site-header\"]/div[3]/div/div/div/div[1]/a"));
            product.Click();
            log.Info("SuccessfullyVerified");
        }
        public void stainRemoval()
        {
            IWebElement stain = BaseClass.driver.FindElement(By.XPath("//*[@id=\"carousel__1hGWzfOCYOPdzihtXedEWa\"]/div[1]/div/ul[1]/li[3]/div/div[2]/div/div"));
            stain.Click();
            log.Info("SuccessfullyVerified");
        }
        public void powder()
        {
            IWebElement powder = BaseClass.driver.FindElement(By.XPath("//a[.='Powder']"));
            powder.Click();
            log.Info("SuccessfullyVerified");
        }
        public void ClickProduct()
        {
            IWebElement pro = BaseClass.driver.FindElement(By.XPath("//*[@id=\"site-content\"]/div/div/div/div[1]/div[5]/div/div/div/div[1]"));
            pro.Click();
            log.Info("SuccessfullyVerified");
        }
        public void Wash()
        {
            IWebElement wash = BaseClass.driver.FindElement(By.XPath("//*[@id=\"site-header\"]/div[3]/div/div/div/div[3]/a"));
            wash.Click();
            log.Info("SuccessfullyVerified");
        }
        public void Satins()
        {
            IWebElement stains = BaseClass.driver.FindElement(By.XPath("//*[@id=\"site-header\"]/div[3]/div/div/div/div[3]/a"));
            stains.Click();
            log.Info("SuccessfullyVerified");
        }
        public void Tide()
        {
            IWebElement tide = BaseClass.driver.FindElement(By.XPath("//*[@id=\"site-header\"]/div[2]/div/div/a/img"));
            tide.Click();
            log.Info("SuccessfullyVerified");
        }
        public void HomePage()
        {
            IWebElement home;
            bool display = true;
            home = BaseClass.driver.FindElement(By.XPath("//span[.='Part of the P&G Family']"));
            log.Info("SuccessfullyVerified");
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile("two.png", ScreenshotImageFormat.Png);
            BaseClass.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            display = home.Displayed;
        }
    }
}
