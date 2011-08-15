using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using DomainWideObjects.DataAccess;
using System.Web;




namespace SeleniumTestMain.General.Data {
    [TestFixture]
    public class DataScraper : IDataScraper {
        #region IDataScraper Members

        private IWebDriver driver;
        private int vehicleID;
        private int searchSessionID;

        private string tableElementHTML;
        private IWebElement tableElement;

   

        // Constructor
        public DataScraper(IWebDriver driver, int vehicleID, int searchSessionID)
        {
            this.driver = driver;
            this.vehicleID = vehicleID;
            this.searchSessionID = searchSessionID;


        }
<<<<<<< HEAD
        [TestCase("test")]
        public int GetHtml(string tagToSearch) {
=======
       
        public void GetHtml(string tagToSearch) {
            // Wait for element
            driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 45));
            
            IWebElement tableElement = driver.FindElement(By.ClassName(tagToSearch));
>>>>>>> edd0abf865ce09f946bd92b37c69c6d49d8630be


            if (CheckElementExists(tagToSearch))
            {
                tableElementHTML =
               (String)((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].innerHTML", tableElement);

                //string encodedHtml =  System.Security.SecurityElement.Escape("<table class=\"t_main\" cellpadding=\"0\" cellspacing=\"0\">");

                string encodedHtml = HttpUtility.HtmlEncode("<table class=\"t_main\" cellpadding=\"0\" cellspacing=\"0\">");

                tableElementHTML = HttpUtility.HtmlDecode(encodedHtml) + tableElementHTML;

                Console.WriteLine(tableElementHTML);

                AddHTMLtoList(tableElementHTML);
                return 0;
            }
           
                // error 1 not found so go back to beginning of loop.
                return 1;

          

            

        }

        private bool CheckElementExists(string tagToSearch)
        {

            // Wait for element
            driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 45));

            bool tableElementExists = false;
            try {
                // Can crash here if filtering the conditions results in nothing found.
                tableElement = driver.FindElement(By.ClassName(tagToSearch));
                tableElementExists = true;
                return tableElementExists;
            } catch (Exception e) {
                // not found
                tableElementExists = false;
                return tableElementExists;
            }
           
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
