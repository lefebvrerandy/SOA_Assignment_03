using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TextService
{
    /// <summary>
    /// Summary description for TextService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TextService : System.Web.Services.WebService
    {
        /* Name:        X
         * Description: X
         * Parameters:  X
         * Return:      X
         */
         [WebMethod]
         public string Case(string incoming, int flag)  // Need to add unsigned
        {
            string newString = string.Empty;

            // Find which method to call
            switch (flag)
            {
                // Convert to upper
                case 1:
                    newString = ConvertToUpper(incoming);
                    break;

                // Convert to lower
                case 2:
                    newString = ConvertToLower(incoming);
                    break;

                // Return an error
                default:
                    newString = "ERROR: Cannot find which method to call. Check flag value (Either 1 or 2).";
                    break;
            }

            return newString;
        }


        /* Name:        X
         * Description: X
         * Parameters:  X
         * Return:      X
         */
        private string ConvertToUpper(string upper)
        {
            return upper.ToUpper();
        }

        /* Name:        X
         * Description: X
         * Parameters:  X
         * Return:      X
         */
        private string ConvertToLower(string lower)
        {
            return lower.ToLower();
        }
    }
}
