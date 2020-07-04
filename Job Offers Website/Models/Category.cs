using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Job_Offers_Website.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="نوع الوظيفة")]
        public String CategoryName { get; set; }

        [Required]
        [Display(Name ="وصف النوع")]
        public String CategoryDescription { get; set; }

        public ICollection<Job> Jobs { get; set; }

    }
} 