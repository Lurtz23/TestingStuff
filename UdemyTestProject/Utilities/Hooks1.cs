﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace UdemyTestProject.Utilities
{
    [Binding]
    public class Hooks1
    {
        public static IWebDriver driver;


        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [BeforeScenario]
        public void FirstBeforeScenario()
        {
           
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // driver.Quit();
        }
    }
}