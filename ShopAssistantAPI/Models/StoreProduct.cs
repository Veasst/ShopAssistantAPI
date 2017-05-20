using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShopAssistantAPI.Models
{
    public class StoreProduct
    {
        [Column(Order = 0), Key]
        public int StoreId { get; set; }
        public Store Store { get; set; }
        [Column(Order = 1), Key]
        public int ProdId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public decimal Weigh { get; set; }
        public decimal PPQ { get; set; }
        public decimal PPW { get; set; }
    }
}