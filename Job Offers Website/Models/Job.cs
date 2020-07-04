using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Job_Offers_Website.Models
{
    public class Job
    {

        public int Id { get; set; }
        [DisplayName("اسم الوظيفة")]
        public String JObTitle { get; set; }
        [DisplayName("وصف الوظيفة")]
        public String JobContent { get; set; }
        [DisplayName("صورة الوظيفة")]
        public String JobImage { get; set; }

        [DisplayName("نوع الوظيفة")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

    }
}