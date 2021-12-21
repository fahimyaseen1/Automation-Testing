using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForChild.Pages
{
    class GmailHomePage
    {
        public IWebDriver driver;

        By CreateAccount = By.ClassName("daaWTb");
        By MyChild = By.ClassName("VfPpkd-StrnGf-rymPhb-b9t22c");
        By Agreed = By.ClassName("VfPpkd-vQzf8d");

        public GmailHomePage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Navigate().GoToUrl("http://www.gmail.com");
        }

        public void TypeCreateAccount()
        {
            driver.FindElement(CreateAccount).Click();
        }
        public void TypeMyChild()
        {
            driver.FindElements(MyChild)[1].Click();
        }

        public void TypeAgreed()
        {
            driver.FindElement(Agreed).Click();
        }
    }
}
