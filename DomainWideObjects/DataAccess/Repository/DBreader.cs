using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainWideObjects.DataAccess.Entities;

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

       public IQueryable<tblSearchSession> GetAllHTMLbySearchSession(int searchSessionID)
       {
           var db = new seleniumScrapeEntities();

           var html = from s in db.tblSearchSessions
                      from h in db.tblHtmls
                      where s.Search_Session_ID_PK == 3
                      select s;                           
                               

           return html;
       }

     

    }
}
