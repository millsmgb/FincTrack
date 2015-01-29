using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinancialsTracker.Models
{
    public class financialItem
    {
        public int fincancialItemId { get; set; }
        public int UserId { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string DateTime { get; set; }

    }
}