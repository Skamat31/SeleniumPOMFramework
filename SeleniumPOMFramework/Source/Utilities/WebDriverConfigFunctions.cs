using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using OpenQA.Selenium.DevTools.V108.PerformanceTimeline;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Edge;
using System.Configuration;
using System.Linq.Expressions;
using Microsoft.Extensions.Configuration;

namespace SeleniumPOMFramework.Source.Utilities
{
    public class WebDriverConfigFunctions
    {
        ConfigSetting config;
        public  static IWebDriver _driver;
      
        [SetUp]
        public void InitScript()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
           String browserName = "Chrome";
           String appUrl = "https://www.cleartrip.com/";

            if (browserName.Equals("Chrome"))
                {
                    new DriverManager().SetUpDriver(new ChromeConfig());
                _driver = new ChromeDriver();
            }
             else if (browserName.Equals("Edge"))
                {
                    new DriverManager().SetUpDriver(new EdgeConfig());
                _driver = new EdgeDriver();
            }
            else
            {
                //print message for browser name data is not matching 
            }
            _driver.Manage().Window.Maximize();

            _driver.Navigate().GoToUrl(appUrl);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
               }


        /*[TearDown]
        public void Cleanup()
        {
            _driver.Quit();
        }*/
    }



 
    
}
