using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainWideObjects.DataAccess {
    public class CreateHTMLlist
    {
        
        private List<HTMLlist> htmlList;

      
        public CreateHTMLlist()
        {
            CreateTable();

        }

        public void CreateTable()
        {

            htmlList = new List<HTMLlist>();
            
            
        }

        public void addToList()
        {
            htmlList.Add(new HTMLlist(){
                                 ListHtml = "Test test test test test"
            
                             });
             htmlList.Add(new HTMLlist(){ListHtml = "Test2 test2 test2 test2 test2"});

        }
        // http://stackoverflow.com/questions/2974868/what-is-the-syntax-in-linq-to-insert-a-record-using-objectset-instead-of-using
        // http://stackoverflow.com/questions/1011519/entity-framework-entitykey-foreign-key-problem

        public void SaveList()
        {
            DataModelContainer db = new DataModelContainer();
          
            foreach (HTMLlist html in htmlList)
          {
              db.HTMLlists.AddObject(html);
          }
            db.SaveChanges();









        }
    }


}
