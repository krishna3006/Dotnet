﻿using System;
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
    class TestEmp
    {
        private IWebDriver driver;
        public string homeURL;
        [SetUp]
        public void SetupTest()
        {
            homeURL = "http://localhost:58572/Employ";
            driver = new ChromeDriver();
        }
        [Test]
        public void EmployInsertSuccess()
        {
            driver.Navigate().GoToUrl(homeURL);
            Thread.Sleep(3000);
            driver.FindElement(By.Name("txtName")).SendKeys("Arun");

            //Type LastName in the LastName text box
            driver.FindElement(By.Name("txtDept")).SendKeys("Dotnet");
            driver.FindElement(By.Name("txtDesig")).SendKeys("Manager");

            //Type LastName in the LastName text box
            driver.FindElement(By.Name("txtBasic")).SendKeys("56643");
            Thread.Sleep(3000);
            // Click on the Submit button
            driver.FindElement(By.Name("btnInsert")).Click();

            //StringAssert.AreEqualIgnoringCase("Record Inserted...", driver.Title);
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
