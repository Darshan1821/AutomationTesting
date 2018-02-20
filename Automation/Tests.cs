using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace Automation
{
    class Tests
    {
        private static IWebDriver webDriver = new ChromeDriver(@"C:\Users\darshan\source\repos\AutomationTesting\AutomationTesting\Library");

        static void Main(string[] args)
        {
            webDriver.Manage().Window.Maximize();

            webDriver.Url = "http://automationpractice.com/index.php";

            Actions actions = new Actions(webDriver);
            IWebElement productImage = webDriver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/div/div[1]/ul[1]/li[2]/div/div[1]/div/a[1]/img"));
            actions.MoveToElement(productImage).Perform();

            var addProduct = webDriver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/div/div[1]/ul[1]/li[2]/div/div[2]/div[2]/a[1]/span"));
            addProduct.Click();

            var countinueShop = webDriver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/span/span"));
            countinueShop.Click();

            var moreDialog = webDriver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/div/div[1]/ul[1]/li[3]/div/div[2]/div[2]/a[2]/span"));
            moreDialog.Click();

            var incrementButton = webDriver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div/div[4]/form/div/div[2]/p[1]/a[2]/span/i"));
            incrementButton.Click();
            incrementButton.Click();

            var addNewProduct = webDriver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div/div[4]/form/div/div[3]/div/p/button"));
            addNewProduct.Click();

            var continueShopping = webDriver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/span/span"));
            continueShopping.Click();

            var tShirtLink = webDriver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[6]/ul/li[3]/a"));
            tShirtLink.Click();

            var sortSelect = webDriver.FindElement(By.Id("selectProductSort"));
            var sortOptions = sortSelect.FindElements(By.TagName("option"))[1];
            sortOptions.Click();

            Actions sortActions = new Actions(webDriver);
            sortActions.MoveToElement(webDriver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div[2]/ul/li/div/div[1]/div/a[1]/img"))).Perform();

            var sortedProduct = webDriver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div[2]/ul/li/div/div[2]/div[2]/a[1]/span"));
            sortedProduct.Click();

            var continueShopping1 = webDriver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/span/span"));
            continueShopping1.Click();

            var cart = webDriver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[3]/div/a"));
            cart.Click();

            var incrementThird = webDriver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div[2]/table/tbody/tr[3]/td[5]/div/a[2]/span/i"));
            incrementThird.Click();
            incrementThird.Click();
            incrementThird.Click();
            incrementThird.Click();

            var checkout = webDriver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/p[2]/a[1]/span"));
            checkout.Click();
        }
    }
}
