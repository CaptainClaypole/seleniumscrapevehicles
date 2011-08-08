using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainWideObjects;
using DomainWideObjects.DataAccess;
using DomainWideObjects.DataAccess.Repository;
using OpenQA.Selenium;
using SeleniumTestMain.General;
using SeleniumTestMain.General.Data;

namespace SeleniumTestMain {
    public class Main
    {
        private string tableHTMLtagToScrape = "t_main";
        

        public void MainMethod()
        {
            //DbTest();


            Navigator navigator = new Navigator();
           // Instanciate objects in the navigator
            navigator.Create();
          


            // create instance of dbreader class to read vehicles to search.
            var dbReader = new DBreader();
            var vehicleSearchList = dbReader.readSearchVehicles();

            // navigate to page
            navigator.NavigateToPage();
            // login to page - return the selenium driver into the var.
            var driver = navigator.LoginToPage();
            


            // Do a search for each vehicle read from the database.
            foreach (var item in vehicleSearchList)
            {
                 MainNavigationToLoop(navigator, item.Vehicle_Make, item.Vehicle_Model, driver);
            }
                
               CloseBrowserAndDispose(driver);
        }

   

        private void MainNavigationToLoop(Navigator navigator,  string vehicleMake, string vehicleModel, IWebDriver driver)
        {

          
            // Begin foreach for all vehicles

            // Select Make
            IVehicleSelector vehicleSelector = new VehicleSelector(driver);
            vehicleSelector.SelectMake(vehicleMake);

            // Select Model
            vehicleSelector.SelectModel(vehicleModel);
            // Condition Picker
            var conditionPicker = new ConditionPicker(driver);

            // Click condition list
            conditionPicker.ClickConditions();

            // Click Search button
            navigator.SearchButtonClicker(driver);



            // Check for the number of pages of the vehicles.
            var pageCounter = new PageCounter(driver);
            var pageNum = pageCounter.pageNumChecker(); // check number of pages and return the number of pages

            // Click next page
            navigator.pageNum = pageNum; // Set the property for the number of pages first

          


            if (pageNum.searchResultsPageCount > 1)
            {
                for (int i = 2; i <= pageNum.searchResultsPageCount; i++) {
                   Console.WriteLine("page number is greater than one so looping...");
                    // Call the datascraper and send through an argument for the class to search for.
                    var dataScraper = new DataScraper(driver);
                    dataScraper.GetHtml(tableHTMLtagToScrape);



                    // Click the next page
                    navigator.ClickNextPage(i);
                }
            }
            else
            {
                Console.WriteLine("Page number returned is one...");
                var dataScraper = new DataScraper(driver);
                dataScraper.GetHtml(tableHTMLtagToScrape);
            }

   

           
        }


        private static void CloseBrowserAndDispose(IWebDriver driver) {
            driver.Close();
            driver.Dispose();
        }

     
    }
}
