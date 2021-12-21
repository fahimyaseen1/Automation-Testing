using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForChild.Pages;


namespace ForChild.Pages
{
    class GmailSignupPage
    {
        public IWebDriver driver;

        public GmailSignupPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GSignupPage()
        {

            GmailHomePage homepage = new GmailHomePage(driver);

            System.Threading.Thread.Sleep(2000);
            homepage.TypeCreateAccount();

            System.Threading.Thread.Sleep(2000);
            homepage.TypeMyChild();
            System.Threading.Thread.Sleep(2000);
            homepage.TypeAgreed();

            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("firstName")).SendKeys("fahim");
            driver.FindElement(By.Name("lastName")).SendKeys("yasin");
            driver.FindElement(By.Id("username")).SendKeys("fahimyaseen001");
            driver.FindElement(By.Name("Passwd")).SendKeys("Fy123456");
            driver.FindElement(By.Name("ConfirmPasswd")).SendKeys("Fy123456");

            System.Threading.Thread.Sleep(2000);

            driver.FindElement(By.Id("accountDetailsNext")).Click();
            System.Threading.Thread.Sleep(3000);

        }
    }
}
