using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert; // ✅ Required for Assertions

namespace demowebshop
{
    public class HomePage : CorePage
    {
        public void AddLaptopToCart()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement computermenu = wait.Until(ExpectedConditions.ElementToBeClickable(
                By.XPath("/html/body/div[4]/div[1]/div[4]/div[1]/div[1]/div[2]/ul/li[2]/a")));
            computermenu.Click();

            // ✅ Assert Computer page opened
            Assert.IsTrue(driver.Url.Contains("computers"), "Computer page did not open!");

            IWebElement notesbooksMenu = wait.Until(ExpectedConditions.ElementToBeClickable(
                By.XPath("/html/body/div[4]/div[1]/div[4]/div[1]/div[1]/div[2]/ul/li[2]/ul/li[2]/a")));
            notesbooksMenu.Click();

            Assert.IsTrue(driver.Url.Contains("notebooks"), "Notebooks page did not open!");

            IWebElement laptopLink = wait.Until(ExpectedConditions.ElementToBeClickable(
                By.XPath("/html/body/div[4]/div[1]/div[4]/div[2]/div[2]/div[2]/div[3]/div/div/div[2]/h2/a")));
            string productName = laptopLink.Text; // ✅ Capture product name
            laptopLink.Click();

            // ✅ Assert product page opened
            IWebElement productTitle = wait.Until(ExpectedConditions.ElementIsVisible(
                By.XPath("//div[@class='product-name']/h1")));
            Assert.AreEqual(productName, productTitle.Text, "Product name mismatch on PDP!");

            IWebElement addToCartButton = wait.Until(ExpectedConditions.ElementToBeClickable(
                By.XPath("//*[@id=\"add-to-cart-button-31\"]")));
            addToCartButton.Click();

            // ✅ Assert success message
            IWebElement successMsg = wait.Until(ExpectedConditions.ElementIsVisible(
                By.CssSelector("p.content")));
            Assert.IsTrue(successMsg.Text.Contains("The product has been added"), "Product not added successfully!");

            IWebElement cartQtyBadge = wait.Until(ExpectedConditions.ElementToBeClickable(
                By.XPath("//*[@id=\"topcartlink\"]/a/span[1]")));
            cartQtyBadge.Click();

            // ✅ Assert cart page opened
            Assert.IsTrue(driver.Url.Contains("cart"), "Shopping cart page not opened!");
        }

        public void CheckOut()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement checkbtn = wait.Until(ExpectedConditions.ElementToBeClickable(
                By.XPath("/html/body/div[4]/div[1]/div[4]/div/div/div[2]/div/form/table/tbody/tr/td[1]/input")));
            checkbtn.Click();

            IWebElement termsOfServiceCheckbox = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("termsofservice")));
            termsOfServiceCheckbox.Click();

            IWebElement checkoutButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("checkout")));
            checkoutButton.Click();

            IWebElement checkoutHeader = wait.Until(ExpectedConditions.ElementIsVisible(
                By.XPath("//h1[contains(text(),'Checkout')]")));

            // ✅ Assert Checkout page
            Assert.AreEqual("Checkout", checkoutHeader.Text, "Checkout page not opened!");
        }

        public void FillBillingAddress()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement continueBtn = wait.Until(ExpectedConditions.ElementToBeClickable(
            By.CssSelector("#billing-buttons-container > input")));
            continueBtn.Click();

            // ✅ Assert Billing step moved ahead
            Assert.IsTrue(driver.PageSource.Contains("Shipping address"), "Did not move to Shipping Address step!");
        }

        public void ContinueShippingAddress()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement continueBtn = wait.Until(ExpectedConditions.ElementToBeClickable(
                By.CssSelector("#shipping-buttons-container > input")));
            continueBtn.Click();

            Assert.IsTrue(driver.PageSource.Contains("Shipping method"), "Did not move to Shipping Method step!");
        }

        public void ContinueShippingMethod()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement continueBtn = wait.Until(ExpectedConditions.ElementToBeClickable(
                By.CssSelector("#shipping-method-buttons-container > input")));
            continueBtn.Click();

            Assert.IsTrue(driver.PageSource.Contains("Payment method"), "Did not move to Payment Method step!");
        }

        public void ContinuePaymentMethod()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement continueBtn = wait.Until(ExpectedConditions.ElementToBeClickable(
                By.CssSelector("#payment-method-buttons-container > input")));
            continueBtn.Click();

            Assert.IsTrue(driver.PageSource.Contains("Payment information"), "Did not move to Payment Info step!");
        }

        public void ContinuePaymentInfo()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement continueBtn = wait.Until(ExpectedConditions.ElementToBeClickable(
                By.CssSelector("#payment-info-buttons-container > input")));
            continueBtn.Click();

            Assert.IsTrue(driver.PageSource.Contains("Confirm order"), "Did not move to Confirm Order step!");
        }

        public void ConfirmOrder()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement confirmBtn = wait.Until(ExpectedConditions.ElementToBeClickable(
                By.CssSelector("#confirm-order-buttons-container > input")));
            confirmBtn.Click();

            IWebElement confirmMsg = wait.Until(ExpectedConditions.ElementIsVisible(
                By.XPath("//strong[contains(text(),'Your order has been successfully processed!')]")));

            // ✅ Assert success confirmation
            Assert.AreEqual("Your order has been successfully processed!", confirmMsg.Text, "Order not confirmed!");
        }

        public void OrderLink()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement orderLink = wait.Until(ExpectedConditions.ElementToBeClickable(
                By.XPath("/html/body/div[4]/div[1]/div[4]/div/div/div[2]/div/ul/li[2]/a")));
            orderLink.Click();

            IWebElement orderInfoHeader = wait.Until(ExpectedConditions.ElementIsVisible(
                By.XPath("/html/body/div[4]/div[1]/div[4]/div/div/div[1]/h1")));

            Assert.AreEqual("Order information", orderInfoHeader.Text, "Order Information page not opened!");
        }

        public string CaptureOrderNumber()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            wait.Until(ExpectedConditions.ElementIsVisible(
                By.XPath("/html/body/div[4]/div[1]/div[4]/div/div/div[1]/h1")));

            IWebElement orderNumberElement = wait.Until(ExpectedConditions.ElementIsVisible(
                By.CssSelector("div.order-number strong")));

            string orderNumber = orderNumberElement.Text;

            // ✅ Regex Validation
            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(orderNumber, @"^Order #\d+$"),
                $"Order number format is invalid! Found: {orderNumber}");

            return orderNumber;
        }
    }
}
