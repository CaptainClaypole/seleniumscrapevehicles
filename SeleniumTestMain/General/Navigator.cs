using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Core;
using Castle;

using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using System.Diagnostics;
using DomainWideObjects;



namespace SeleniumTestMain
{
    internal interface INavigatable
    {
        void Create();
        void Finish();
        void NavigateToPage();
    }

    internal class Navigator : INavigatable
    {
        private string navUri;
        private IWebDriver driver;


        private SiteConfigurator siteConfig;
        private Website website;

        // Set initial page number integer
        private int pageNum = 1;



        public void Create()
        {
            driver = new FirefoxDriver();
            //instanciate the website class.
            website = new Website();

            // Instanciate site configuration class.
            siteConfig = new SiteConfigurator(website);




        }




        public void NavigateToPage()
        {


            driver.Navigate().GoToUrl("http://www.jpcenter.ru");

        }

        public IWebDriver LoginToPage()
        {

            Authenticator authenticator = new Authenticator(website, driver);
            // Call the authenticate method.
            authenticator.Authenticate();

            // return the webdriver object
            return driver;


        }

        public void pageNumChecker()
        {
            int pageNumCounted = 1;
            pageNum = 1;

      

            // proper while
            while (CheckForNextPage())
            {
                pageNumCounted = pageNum;
                Console.WriteLine(pageNumCounted);
                // increment page number to see if it exists.
                pageNum++;
            }

            Console.WriteLine("hello");
        }

        public bool CheckForNextPage()
        {
            // Wait for element
            driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 1));
            try {

                driver.FindElement(By.XPath("//a[@onclick='navi(this," + pageNum + ");']"));

                return true;
            } catch (Exception e) {
                // not found!!

                return false;
            }



         
        }




        public void Finish()
        {
            driver.Close();

        }



    }
}
