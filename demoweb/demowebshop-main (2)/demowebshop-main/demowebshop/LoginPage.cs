using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demowebshop
{ 
    public class LoginPage : CorePage
    {
        By registermebtn = By.XPath("/html/body/div[4]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a");
        By usernametxt = By.Id("Email");
        By passwordtxt = By.Id("Password");
        By loginbtn = By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div/div[2]/div[1]/div[2]/div[2]/form/div[5]/input");

        public void Login(String url, string username, string password)
        {

            driver.Url = url;

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement registermebtn = wait.Until(ExpectedConditions.ElementToBeClickable(
               By.XPath("/html/body/div[4]/div[1]/div[1]/div[2]/div[1]/ul/li[2]/a")));

            registermebtn.Click();
            
            IWebElement identifierField = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("Email")));
            identifierField.SendKeys(username);
              
            
            IWebElement passwordField = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("Password")));
            passwordField.SendKeys(password);

            IWebElement loginButton = wait.Until(ExpectedConditions.ElementToBeClickable(
                By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div/div[2]/div[1]/div[2]/div[2]/form/div[5]/input")));
            loginButton.Click();

        }
    }
}

