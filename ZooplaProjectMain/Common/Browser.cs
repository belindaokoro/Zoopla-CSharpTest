using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace ZooplaProjectMain.Common
{
    public class Browser : Driver
    {
        private OpenQA.Selenium.IWebDriver InitChromeDriver()
        {
            new WebDriverManager
                .DriverManager()
                .SetUpDriver(new ChromeConfig());

            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-gpu", "--headless");
            return new ChromeDriver(options);

        }

        public void LaunchBrowser(string browser)
        {   switch (browser)
            {
               case "Chrome":
                  _driver = InitChromeDriver();
                break;

                case "Headless":
                  _driver = InitChromeDriver();
                break;

                default:
                  _driver = InitChromeDriver();
                break;


            }
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait
                                = TimeSpan.FromSeconds(10);
            _driver.Manage().Timeouts().PageLoad
                                = TimeSpan.FromSeconds(30);
        }
    }
}
