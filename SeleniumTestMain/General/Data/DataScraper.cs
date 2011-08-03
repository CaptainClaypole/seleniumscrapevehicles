using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using DomainWideObjects.DataAccess;




namespace SeleniumTestMain.General.Data {
    class DataScraper : IDataScraper {
        #region IDataScraper Members

        private IWebDriver driver;
   

        // Constructor
        public DataScraper(IWebDriver driver)
        {
            this.driver = driver;
            

        }

        public void GetHtml(string tagToSearch) {
            // Wait for element
            driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 45));
            
            IWebElement tableElement = driver.FindElement(By.ClassName(tagToSearch));

            string tableElementHTML =
                (String)((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].innerHTML", tableElement);

            Console.WriteLine(tableElementHTML);
           

            AddHTMLtoList(tableElementHTML);

        }

        public void AddHTMLtoList(string tableElementHTML)
        {
           // Add the scraped html to the list.
            var htmlData = new HTMLlist() { 
            
                ListHtml = tableElementHTML
                            
            };

            // Add to db
            AddToDb(htmlData);

  

        }

        private void AddToDb(HTMLlist htmlData) {

            var addHtmlToDb = new CreateHTMLlist();

            addHtmlToDb.InsertList(htmlData);

        }

        

        #endregion
    }
}
