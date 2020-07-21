using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Job_Offers_Website.Models
{
    public class ContactModel
    {
        [Display(Name = "الأسم")]
        public string Name { get; set; }
        [Display(Name = "البريد الألكترونى")]
        public string Email { get; set; }
        [Display(Name = "عنوان الرسالة")]
        public string Subject { get; set; }
        [Display(Name = "الرسالة")]
        public string Message { get; set; }

    }
}