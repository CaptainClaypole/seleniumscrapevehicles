using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;

namespace DomainWideObjects.DataAccess.Repository {
    public class DataRepository<T> : IRepository<T> where T : class
    {

        #region IRepository<T> Members

        private ObjectContext _context;

        private IObjectSet<T> _objectSet;

        // Constructor
        public DataRepository()
            : this(new seleniumScrapeEntities())
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the DataRepository class
        /// </summary>
        /// <param name="context">The Entity Framework ObjectContext</param>
        public DataRepository(ObjectContext context) {
            _context = context;
            _objectSet = _context.CreateObjectSet<T>();
        }
 
        

        public IQueryable<T> Fetch()
        {
            return _objectSet;
        }

        public IEnumerable<T> GetAll()
        {
            return Fetch().AsEnumerable();

        }

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return _objectSet.Where<T>(predicate);
        }

        public T Single(Func<T, bool> predicate) {
            
            return _objectSet.Single<T>(predicate);
        }

        public T First(Func<T, bool> predicate) {
            return _objectSet.First<T>(predicate);
        }

        public void Add(T entity) {
            if (entity == null) {
                throw new ArgumentNullException("entity");
            }

            _objectSet.AddObject(entity);
        }

        public void Delete(T entity) {
           
            if (entity == null) {
                throw new ArgumentNullException("entity");
            }

            _objectSet.DeleteObject(entity);
        }

        //protected virtual void Delete(T entity) {

        //    IEnumerable<T> records = from x in _objectSet.Where<T>(predicate) select x;

        //    foreach (T record in records) {
        //        _objectSet.DeleteObject(record);
        //    }
        //}

        public void Attach(T entity) {
            _objectSet.Attach(entity);
        }

        public void SaveChanges() {
            _context.SaveChanges();
        }

        public void SaveChanges(System.Data.Objects.SaveOptions options) {
            _context.SaveChanges(options);
        }

        #endregion

        #region IDisposable Members

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing) {
            if (disposing) {
                if (_context != null) {
                    _context.Dispose();
                    _context = null;
                }
            }
        }

        #endregion
    }
}
