using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForChild.Pages;

namespace ForChild
{
    class MainChildClass
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            GmailSignupPage gmail = new GmailSignupPage(driver);

            gmail.GSignupPage();
        }
    }
}
