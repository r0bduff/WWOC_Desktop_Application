using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWOC_Desktop_App
{
    class Part
    {
        //maybe dont use this
        public int partID { get; set; }
        public string itemDesc { get; set; }
        public float costUSD { get; set; }
        public int vendorID { get; set; }
        public int qtyOH { get; set; }
        public int reorderPoint { get; set; }
        public int exptdLife { get; set; }
        public string shipmentTime { get; set; }
        public int locationID { get; set; }


    }
}
