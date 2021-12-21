using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMySelf.Pages
{
    class GmailHomePage
    {
        public IWebDriver driver;

        By CreateAccount = By.ClassName("daaWTb");
        By MySelf = By.ClassName("VfPpkd-StrnGf-rymPhb-b9t22c");

        public GmailHomePage(IWebDriver driver)
        {
           this.driver = driver;
           driver.Navigate().GoToUrl("http://www.gmail.com");
        }

        public void TypeCreateAccount()
        {
            driver.FindElement(CreateAccount).Click();
        }

        public void TypeMySelf()
        {
            driver.FindElement(MySelf).Click();
        }
    }
}
