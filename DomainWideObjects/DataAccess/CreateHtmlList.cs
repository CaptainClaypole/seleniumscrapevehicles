using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainWideObjects.DataAccess {
    public class CreateHTMLlist
    {
        
              
        // http://stackoverflow.com/questions/2974868/what-is-the-syntax-in-linq-to-insert-a-record-using-objectset-instead-of-using
        // http://stackoverflow.com/questions/1011519/entity-framework-entitykey-foreign-key-problem

        public void InsertList(HTMLlist htmlListObject) {

            // Create database context.
            var ctx = new DataModelContainer();

            ctx.HTMLlists.AddObject(htmlListObject);
            ctx.SaveChanges();





        }
      
    }


}
