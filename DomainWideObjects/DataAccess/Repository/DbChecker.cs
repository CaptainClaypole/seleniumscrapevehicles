using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using DomainWideObjects.DataAccess;

namespace DomainWideObjects.DataAccess.Repository {
    public class DbChecker<T> where T : class
    {

        private ObjectContext _context;
        private IObjectSet<T> _objectSet;

           // Constructor
        public DbChecker()
            : this(new seleniumScrapeEntities())
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the DataRepository class
        /// </summary>
        /// <param name="context">The Entity Framework ObjectContext</param>
        public DbChecker(ObjectContext context) {
            _context = context;
            _objectSet = _context.CreateObjectSet<T>();
        }

        public void checkExists()
        {

            string country = "SwarzyLand"
            
            var ctx = new seleniumScrapeEntities();

             
            // Get the ID of the country being inserted, if it exists then obv. add it as foreign key.
            // if its null then it doesnt exist so you would create a new one.
            var resultType = (from c in ctx.tblVehicleTypeCountries
                        where c.Vehicle_Type == country
                        select c.Vehicle_Type).FirstOrDefault();

            if (resultType == null)
            {
                // if the query result is null, proceed to add a new country
                // else you would want to select it.
            }

            else
            {
                
            var vehicle = new tblVehicle
                              {
                                  Vehicle_Make = "John Deere",
                                  Vehicle_Model = "Night Terror 14 killah",
                                 


                               
                              };
            // save to db
           

            }

            ;

        }




    }
}
