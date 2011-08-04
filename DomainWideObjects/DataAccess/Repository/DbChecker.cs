using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;

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




    }
}
