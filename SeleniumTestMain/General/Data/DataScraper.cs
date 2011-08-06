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

            string vehicleMake = "TOYOTA";
            string vehicleModel = "HIACE VAN"

            string country = "Japanese";
            string defined = "Super Robinson";
            string general = "campertronic";

            bool vehicleExists = CheckVehicleExists(vehicleMake, vehicleModel);

            if (!vehicleExists)
            {
           bool countryExists =  CheckCountryExists(country);
           bool definedExists = CheckDefinedTypeExists(defined);
           bool generalExists = CheckGeneralTypeExists(general);
          // Create new vehicle object.
            var vehicle = new tblVehicle(); 
               vehicle.Vehicle_Make = "Toyota";
                vehicle.Vehicle_Model = "Camroad";
             

            if (countryExists)
            {

                var db2 = new seleniumScrapeEntities();
              
                                      // Set the Vehicle Country of Origin FK (in vehicle table)
                vehicle.Vehicle_Type_ID_fk =
                    db2.tblVehicleTypeCountries.Where(x => x.Vehicle_Type == country).Select(
                        x => x.Vehicle_Type_Country_ID_pk).SingleOrDefault();

                db2.Dispose();


            }
            else
            {
                // Create new country
            }
              
            if (generalExists)
            {
                var db2 = new seleniumScrapeEntities();

                // Set the Vehicle Defined Type FK (in vehicle table)
                vehicle.Vehicle_Type_Defined_fk =
                    db2.tblVehicleTypeDefineds.Where(x => x.VehicleTypeDefined == defined).Select(
                        x => x.VehicleTypeDefined_id_pk).SingleOrDefault();
                   db2.Dispose();
            }else
            {
                // Create new Defined Type.
            }
            if (definedExists)
            {
                var db2 = new seleniumScrapeEntities();  
                // Set the Vehicle General Type FK (in vehicle table)
                vehicle.Vehicle_Type_General_id_fk =
                    db2.tblVehicleTypeGenerals.Where(x => x.VehicleTypeGeneral == general).Select(
                        x => x.VehicleTypeGeneral_pk).SingleOrDefault();
                db2.Dispose();
            }else
            {
                // Create new general type.
            }
            }

          


        }

        private bool CheckVehicleExists(string vehicleMake, string vehicleModel) {
            var db = new seleniumScrapeEntities();

            //var query = db.tblVehicleTypeCountries.Where(x => x.Vehicle_Type == p);
            var query = db.tblVehicles.Where(x => x.Vehicle_Make == vehicleMake);
            query = db.tblVehicles.Where(x => x.Vehicle_Model == vehicleModel);


            if (query.Count() > 0) {
                return false;
            }



            return true; ;
        }

        private bool CheckGeneralTypeExists(string general) {
            var db = new seleniumScrapeEntities();

            var query = db.tblVehicleTypeGenerals.Where(x => x.VehicleTypeGeneral == general);

            if (query.Count() > 0) {
                return false;
            }



            return true;
        }

        private bool CheckDefinedTypeExists(string defined) {
            var db = new seleniumScrapeEntities();

            var query = db.tblVehicleTypeDefineds.Where(x => x.VehicleTypeDefined == defined);

            if (query.Count() > 0) {
                return false;
            }



            return true;
        }

        private bool CheckCountryExists(string p)
        {

            var db = new seleniumScrapeEntities();

            var query = db.tblVehicleTypeCountries.Where(x => x.Vehicle_Type == p);

            if (query.Count() > 0)
            {
                return false;
            }



            return true;

        }

      


   


        public void SaveNewVehicleToDB(tblVehicle vehicle)
        {

            var vehicleSaver = new VehicleSaver();
            vehicleSaver.SaveToDB(vehicle);


        }

        

        #endregion
    }
}
