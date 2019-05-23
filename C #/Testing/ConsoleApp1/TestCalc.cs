﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace ConsoleApp1
{
    [TestFixture]
    class TestCalc
    {
        private IWebDriver driver;
        public string homeURL;

        [SetUp]

        public void SetupTest()
        {
            homeURL = "http://localhost:57863/Calc";
            driver = new ChromeDriver();

        }

        [Test]
        public void CalcTestValidation()
        {
            driver.Navigate().GoToUrl(homeURL);
            Thread.Sleep(3000);
            driver.FindElement(By.Name("txtFirstNo")).SendKeys("");

            //Type LastName in the LastName text box
            driver.FindElement(By.Name("txtSecondNo")).SendKeys("");
            Thread.Sleep(3000);
            // Click on the Submit button
            driver.FindElement(By.Name("btnSum")).Click();
            Thread.Sleep(3000);
            //driver.FindElement(By.Name("btnSub")).Click();
            //Thread.Sleep(3000);
            //driver.FindElement(By.Name("btnMult")).Click();
            //Thread.Sleep(3000);

            driver.Quit();

        }


        [Test]
        public void CalcTestSuccess()
        {
            driver.Navigate().GoToUrl(homeURL);
            Thread.Sleep(3000);
            driver.FindElement(By.Name("txtFirstNo")).SendKeys("12");

            //Type LastName in the LastName text box
            driver.FindElement(By.Name("txtSecondNo")).SendKeys("15");
            Thread.Sleep(3000);
            // Click on the Submit button
            driver.FindElement(By.Name("btnSum")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Name("btnSub")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Name("btnMult")).Click();
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}