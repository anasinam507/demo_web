using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace demowebshop
{
    public class CorePage
    {
        public static IWebDriver driver;

        public static IWebDriver SeleniumInit()
        {
            IWebDriver chromeDriver = new ChromeDriver();
            driver = chromeDriver;
            driver.Manage().Window.Maximize();
            return driver; //initializing chrome

        }

    }
}
