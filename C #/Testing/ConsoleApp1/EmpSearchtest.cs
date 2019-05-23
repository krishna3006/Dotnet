using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace ConsoleApp1
{
    [TestFixture]
    class EmpSearchtest
    {
        private IWebDriver driver;
        public string homeURL;
        [SetUp]
        public void SetupTest()
        {
            homeURL = "http://localhost:58752/EmpSearch";
            driver = new ChromeDriver();
        }
        [Test]
        public void EmploySearchSuccess()
        {
            driver.Navigate().GoToUrl(homeURL);
            Thread.Sleep(3000);
            driver.FindElement(By.Name("txtEmployno")).SendKeys("25");
            driver.FindElement(By.Name("btnSearch")).Click();
            //Type LastName in the LastName text box
            string name = driver.FindElement(By.Name("txtName")).GetAttribute("value").ToString();
            StringAssert.AreEqualIgnoringCase("Bhargav", name);
            string dept = driver.FindElement(By.Name("txtDept")).GetAttribute("value").ToString();
            StringAssert.AreEqualIgnoringCase("Java", dept);
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
  
