using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterDaimonTestProject.Pages
{
    public class GoogleHomePage
    {
        public IWebDriver driver = new ChromeDriver();

        public IWebElement searchBar() { return driver.FindElement(By.XPath("//input[@title='Search']")); }
        public IWebElement searchButton() { return driver.FindElement(By.XPath("(//input[@value='Google Search'])[2]")); }
        public IWebElement firstResultDescription() { return driver.FindElement(By.XPath("//*[@id='rso']/div[1]/div/div/div/div/div/div/div/div[1]/a/div/cite")); }
        
        public void Initialize()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://google.com");
        }

        public bool searchForStackOverflow()
        {
            searchBar().SendKeys("stackoverflow");
            searchBar().SendKeys(Keys.Enter);
            Console.WriteLine("Actual Text: ");
            Thread.Sleep(10000);
            Console.WriteLine(firstResultDescription().Text);
            if (firstResultDescription().Text.Contains("stackoverflow"))
            {
                driver.Close();
                driver.Dispose();
                return true;
            }else
            {
                driver.Close();
                driver.Dispose();
                return false;
            }

            

        }


        
        
    }
}
