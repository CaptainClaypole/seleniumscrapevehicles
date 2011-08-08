using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainWideObjects.DataAccess.Repository {
   public class DBreader {


       public List<tblVehicle> readSearchVehicles()
       {
           var db = new seleniumScrapeEntities();

           var vehicles = from v in db.tblVehicles
                          where v.Vehicle_WillBeSearched == true
                          select v;

           var vehicleList = vehicles.ToList();


           return vehicleList;


       }

    }
}
