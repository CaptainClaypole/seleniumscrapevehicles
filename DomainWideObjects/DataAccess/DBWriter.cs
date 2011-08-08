using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainWideObjects.DataAccess;

namespace SeleniumTestMain.General.Data {
   public class DBWriter {
       
       
       public int InsertSearchSession(tblSearchSession searchSession) {

           // Create database context.
           var ctx = new seleniumScrapeEntities();

           ctx.tblSearchSessions.AddObject(searchSession);
           ctx.SaveChanges();
           
           return searchSession.Search_Session_ID_PK;
       }
    }
}
