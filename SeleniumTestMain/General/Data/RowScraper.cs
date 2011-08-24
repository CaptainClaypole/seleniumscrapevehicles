using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using OpenQA.Selenium;

namespace SeleniumTestMain.General.Data {
    public class RowScraper : IRowScraper
    {

        private IWebDriver driver;
        private int searchSessionID;
        private string rowElementHTML;
        private IWebElement tableRowElement;
       
        private int vehicleID;


        // Construct
        public RowScraper(IWebDriver driver, int searchSessionId, int vehicleID)
        {
            this.driver = driver;
            this.searchSessionID = searchSessionId;
            this.vehicleID = vehicleID;

        }


        

        public int GetSingleRowHtml(string tagToSearch)
        {
            for (int i = 0; i < 20; i++)
            {
                
         
                if (CheckElementExists(tagToSearch, i)) {
                    rowElementHTML =
                   (String)((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].innerHTML", tableRowElement);

                    //string encodedHtml =  System.Security.SecurityElement.Escape("<table class=\"t_main\" cellpadding=\"0\" cellspacing=\"0\">");

                    string encodedHtml = HttpUtility.HtmlEncode("<table class=\"t_main\" cellpadding=\"0\" cellspacing=\"0\">");

                    rowElementHTML = HttpUtility.HtmlDecode(encodedHtml) + rowElementHTML;

                    Console.WriteLine("Writing Row Element Data! ******" + rowElementHTML + "*************");
                    Console.WriteLine("Written data aj_view" + i);
                    // Console.ReadLine();

                    //  AddHTMLtoList(rowElementHTML);

                    

                    // return 0;
                }
                else
                {
                    return 1;
                }


             

            }

            Console.WriteLine("***FINISHED SCRAPING SINGLE ROWS***");
           // Console.ReadLine();

            // error 1 not found so go back to beginning of loop.
            return 1;

          
        }

        public bool CheckElementExists(string tagToSearch, int i)
        {
            // Wait for element
            driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 2));

            bool tableElementExists = false;
            try {
                // Can crash here if filtering the conditions results in nothing found.
                tableRowElement = driver.FindElement(By.Id(tagToSearch + i));
                tableElementExists = true;

                driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 45));

                return tableElementExists;
            } catch (Exception e) {
                // not found
                tableElementExists = false;

                driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 45));

                return tableElementExists;
            }
        }



    }
}
