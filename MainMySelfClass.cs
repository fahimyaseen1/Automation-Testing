using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForMySelf.Pages;
using NUnit.Framework;


namespace PageObjectModel
{
    public class MainMySelfClass
    {
        static void Main(string[] args)
        {
           IWebDriver driver = new ChromeDriver();
           GmailSignupPage gmail = new GmailSignupPage(driver);

            gmail.GSignupPage();
        }
    }
}
