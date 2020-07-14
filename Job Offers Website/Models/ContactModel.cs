using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Job_Offers_Website.Models
{
    public class ContactModel
    {
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }

        public string Subject { get; set; }
        public string Message { get; set; }
    }
}