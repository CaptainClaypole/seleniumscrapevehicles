using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainWideObjects;
using SeleniumTestMain.General;
using SeleniumTestMain.General.Data;

namespace SeleniumTestMain {
    public class Main
    {
       

        public void MainMethod()
        {
            Navigator navigator = new Navigator();
           // Instanciate objects in the navigator
            navigator.Create();
            // navigate to page
            navigator.NavigateToPage();
            // login to page - return the selenium driver into the var.
            var driver = navigator.LoginToPage();
            // Select Make
            IVehicleSelector vehicleSelector = new VehicleSelector(driver);
            vehicleSelector.SelectMake();
            // Select Model
            vehicleSelector.SelectModel();
            // Drag Slider Test
            var dataScraper = new DataScraper(driver);

            // Call the datascraper and send through an argument for the class to search for.
            dataScraper.GetHtml("t_main");
            
            // Check for the number of pages of the vehicles.
            navigator.pageNumChecker();








        }
    }
}
