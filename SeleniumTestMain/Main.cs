using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainWideObjects;
using DomainWideObjects.DataAccess;
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
            // navigate to page
            navigator.NavigateToPage();
            // login to page - return the selenium driver into the var.
            var driver = navigator.LoginToPage();
            // Begin foreach for all vehicles

            
          

           
            
                
                MainNavigationToLoop(navigator, driver);
            
            
               

           
            
            

           
        }

        private void MainNavigationToLoop(Navigator navigator, IWebDriver driver)
        {
            // Select Make
            IVehicleSelector vehicleSelector = new VehicleSelector(driver);
            vehicleSelector.SelectMake("TOYOTA");

            // Select Model
            vehicleSelector.SelectModel("TOWN ACE TRUCK");
            // Condition Picker
            var conditionPicker = new ConditionPicker(driver);

            // Click condition list
            conditionPicker.ClickConditions();

            // Click Search button


            // Check for the number of pages of the vehicles.
            var pageCounter = new PageCounter(driver);
            var pageNum = pageCounter.pageNumChecker(); // check number of pages and return the number of pages

            // Click next page
            navigator.pageNum = pageNum; // Set the property for the number of pages first


            for (int i = 1; i <= pageNum.searchResultsPageCount; i++)
            {
                // Call the datascraper and send through an argument for the class to search for.
                var dataScraper = new DataScraper(driver);
                dataScraper.GetHtml(tableHTMLtagToScrape);

                // Add new vehicle (test)
                dataScraper.AddNewVehicle();


                // Click the next page
                navigator.ClickNextPage(i);
            }
        }

        //private void DbTest()
        //{
        //    CreateHTMLlist createHtmlList = new CreateHTMLlist();
        //    Console.WriteLine("about to add to list...");
        //    createHtmlList.addToList();
        //    Console.ReadLine();
        //    Console.WriteLine("about to save to db...");
        //    createHtmlList.SaveList();
        //    Console.ReadLine();
        //}
    }
}
