using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShopAssistantAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int ProdCategoryId { get; set; }
        public ProdCategory ProdCategory { get; set; }
        public string Photo { get; set; }
    }
}