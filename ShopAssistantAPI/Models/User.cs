using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShopAssistantAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        // Foreign key
        public int UserTypeId { get; set; }
        // Navigation property
        public UserType UserType { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
    }
}