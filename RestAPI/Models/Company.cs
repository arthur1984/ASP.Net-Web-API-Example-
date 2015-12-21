using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RestAPI.Models
{
    public class Company
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime ExpirationDate { get; set; }
        
    }
}