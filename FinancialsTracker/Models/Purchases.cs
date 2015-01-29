using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinancialsTracker.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public int UserId { get; set;}
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public System.DateTime DateTime { get; set; }
        public string Location { get; set; }
    }
}