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
            var htmlData = new tblHtml { 
            
                html_data = tableElementHTML
                            
            };

            // Add to db
            AddToDb(htmlData);

  

        }

        private void AddToDb(tblHtml htmlData) {

            var addHtmlToDb = new CreateHTMLlist();

            addHtmlToDb.InsertList(htmlData);

        }

        public void AddNewVehicle()
        {
            //var vehicleCountry = new tblVehicleTypeCountry()
            //                         {
            //                             Vehicle_Type = "SwarziLand"
            //                         };

           


            var vehicleGeneral = new tblVehicleTypeGeneral()
                                     {
                                         VehicleTypeGeneral = "Tractor"

                                     };

            var vehicleDefined = new tblVehicleTypeDefined()
                                     {
                                         VehicleTypeDefined = "Night Attack Tractor"

                                     };


            var vehicle = new tblVehicle
                              {
                                  Vehicle_Make = "John Deere",
                                  Vehicle_Model = "Night Terror 14 killah",
                                  //tblVehicleTypeCountry = vehicleCountry,
                                  tblVehicleTypeGeneral = vehicleGeneral,
                                  tblVehicleTypeDefined = vehicleDefined


                              };
            // save to db
            SaveNewVehicleToDB(vehicle);

        }


        private tblVehicleTypeCountry CheckExists(string value)
        {
            var ctx = new seleniumScrapeEntities();

            var vehicleCountry = new tblVehicleTypeCountry()
                                     {
                                         Vehicle_Type = "SwarzyLand"
                                     };
            return vehicleCountry;
        }


        public void SaveNewVehicleToDB(tblVehicle vehicle)
        {

            var vehicleSaver = new VehicleSaver();
            vehicleSaver.SaveToDB(vehicle);


        }

        

        #endregion
    }
}
