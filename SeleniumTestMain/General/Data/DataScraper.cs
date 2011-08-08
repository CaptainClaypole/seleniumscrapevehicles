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
        private int vehicleID;
        private int searchSessionID;

   

        // Constructor
        public DataScraper(IWebDriver driver, int vehicleID, int searchSessionID)
        {
            this.driver = driver;
            this.vehicleID = vehicleID;
            this.searchSessionID = searchSessionID;


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
            var htmlData = new tblHtml { 
            
                html_data = tableElementHTML,
                // Set the vehicle ID for the HTML
                Vehicle_id_fk = vehicleID,
                // Set the Time Stamp field
                Search_Date_Timestamp = DateTime.Now,
                // Set the search session
                Search_Session_ID_fk = searchSessionID
                
                
                            
            };

            // Add to db
            AddToDb(htmlData);

  

        }

      

        private void AddToDb(tblHtml htmlData) {

            var addHtmlToDb = new CreateHTMLlist();

            addHtmlToDb.InsertList(htmlData);

        }

     
      


   


        public void SaveNewVehicleToDB(tblVehicle vehicle)
        {

            var vehicleSaver = new VehicleSaver();
            vehicleSaver.SaveToDB(vehicle);


        }

        

        #endregion
    }
}
