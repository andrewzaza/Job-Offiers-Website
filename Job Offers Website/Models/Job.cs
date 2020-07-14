using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace Job_Offers_Website.Models
{
    public class Job
    {

        public int Id { get; set; }
        [DisplayName("اسم الوظيفة")]
        public String JObTitle { get; set; }
        [DisplayName("وصف الوظيفة")]
        [AllowHtml]
        public String JobContent { get; set; }
        [DisplayName("صورة الوظيفة")]
        public String JobImage { get; set; }

        [DisplayName("نوع الوظيفة")]
        public int CategoryId { get; set; }
        public string UserID { get; set; }

        public virtual Category Category { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}