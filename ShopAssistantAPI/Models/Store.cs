using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopAssistantAPI.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
    }
}