using demowebshop;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Text.RegularExpressions;

namespace demowebshop
{
    [TestClass]
    public class TestExecution
    {
        //IWebDriver driver = new ChromeDriver();
        LoginPage loginPage = new LoginPage();


        [TestMethod]
        public void Login_ValidCredentials()
        {
            CorePage.SeleniumInit();
            loginPage.Login("https://demowebshop.tricentis.com/", "abbasiaqsa18@gmail.com", "Test@123");
            WebDriverWait wait = new WebDriverWait(CorePage.driver, TimeSpan.FromSeconds(10));

            String pageTitle = wait.Until(ExpectedConditions.ElementIsVisible
                (By.XPath("/html/body/div[4]/div[1]/div[4]/div[3]/div/div/div[2]/div[1]/h2"))).Text;

            Assert.AreEqual("Welcome to our store", pageTitle);

            CorePage.driver.Close();


        }



        [TestMethod]
        public void Login_invalidCredentials()
        {
            CorePage.SeleniumInit();
            loginPage.Login("https://demowebshop.tricentis.com/", "abbasiaqsa18@gmail.com", "Test@123456");
            WebDriverWait wait = new WebDriverWait(CorePage.driver, TimeSpan.FromSeconds(10));

            IWebElement errorElement = wait.Until(
      ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div/div[2]/div[1]/div[2]/div[2]/form/div[1]/div/span")));
            string errorText = errorElement.Text;

            Assert.AreEqual("Login was unsuccessful. Please correct the errors and try again.", errorText);
            CorePage.driver.Close();

        }
        [TestMethod]
        public void Add_to_cart()
        {
            // Initialize driver
            CorePage.SeleniumInit();
            LoginPage loginPage = new LoginPage();
            HomePage homePage = new HomePage(); // Create an instance of HomePage
            loginPage.Login("https://demowebshop.tricentis.com/", "abbasiaqsa18@gmail.com", "Test@123");

            homePage.AddLaptopToCart(); // Use the instance to call the method
            CorePage.driver.Close();
        }
        [TestMethod]
        public void CheckOut_Flow()
        {
            CorePage.SeleniumInit();
            CorePage.driver.Url = "https://demowebshop.tricentis.com/";

            
            LoginPage login = new LoginPage();
            login.Login("https://demowebshop.tricentis.com/", "abbasiaqsa18@gmail.com", "Test@123");

            
            HomePage home = new HomePage();
            home.AddLaptopToCart();

          
            home.CheckOut();
            CorePage.driver.Close();
        }

        [TestMethod]
        public void Order_PurchaseFlow()
        {
            CorePage.SeleniumInit();
            CorePage.driver.Url = "https://demowebshop.tricentis.com/";

            // Login first
            LoginPage login = new LoginPage();
            login.Login("https://demowebshop.tricentis.com/", "abbasiaqsa18@gmail.com", "Test@123");

            // Add Laptop to Cart
            HomePage home = new HomePage();
            home.AddLaptopToCart();
            home.CheckOut();

            // Checkout Flow
            // Remove: checkout = new CheckoutPage();
            // Use the existing 'home' instance of HomePage
            home.FillBillingAddress();
            home.ContinueShippingAddress();
            home.ContinueShippingMethod();
            home.ContinuePaymentMethod();
            home.ContinuePaymentInfo();
            home.ConfirmOrder();
            home.OrderLink();


            CorePage.driver.Close();
        }
        [TestMethod]
        public void Order_Capture()
        {
            CorePage.SeleniumInit();
            CorePage.driver.Url = "https://demowebshop.tricentis.com/";

            // Login first
            LoginPage login = new LoginPage();
            login.Login("https://demowebshop.tricentis.com/", "abbasiaqsa18@gmail.com", "Test@123");

            // Add Laptop to Cart
            HomePage home = new HomePage();
            home.AddLaptopToCart();
            home.CheckOut();

            // Checkout Flow
            home.FillBillingAddress();
            home.ContinueShippingAddress();
            home.ContinueShippingMethod();
            home.ContinuePaymentMethod();
            home.ContinuePaymentInfo();
            home.ConfirmOrder();
            home.OrderLink();

           
    string orderNumber = home.CaptureOrderNumber();
            Console.WriteLine("Order Number: " + orderNumber);

            Assert.IsTrue(!string.IsNullOrEmpty(orderNumber), "Order Number was not captured!");

            CorePage.driver.Close();

        }


    }

}