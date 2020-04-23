using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWOC_Desktop_App
{
    class Order
    {
        public int orderID { get; set; }
        public int partID { get; set; }
        public int userID { get; set; }
        public int vendorID { get; set; }
        public DateTime poDate { get; set; }
        public string shippingTime { get; set; }
        public float unitPrice { get; set; }
        public int qty { get; set; }
        public string description { get; set; }
        public string terms { get; set; }
        public float subtotal { get; set; }
        public float salesTax { get; set; }
        public float shippingHandling { get; set; }
        public float otherCharges { get; set; }
        public float totalPrice { get; set; }
        public Boolean approved { get; set; }

       
        /* Once partID is given the rest of the data can be filled
         * 
         */
        public void FillPartInfo()
        {

        }

        /* Updates the Database
         * 
         */
        public void UpdateDatabase()
        {

        }
    }
}
