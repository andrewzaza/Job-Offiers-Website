using Job_Offers_Website.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
            
        {
            return View(db.Categories.ToList());
        }

        public ActionResult Details (int JobId)
        {
            var job = db.Jobs.Find(JobId);
            
            if(job == null)
            {
                return HttpNotFound();
           
            }
            Session["JobId"] = JobId; 
            return View(job);
        }
        [Authorize]
         public ActionResult Apply()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Apply(string Message)
        {
            var UserId = User.Identity.GetUserId();
            var JobId = (int)Session["JobId"];

            var check = db.ApplyForJobs.Where(a => a.JobId == JobId && a.UserId == UserId).ToList();

            if (check.Count < 1)
            {
                var job = new ApplyForJob();

                job.UserId = UserId;
                job.JobId = JobId;
                job.Message = Message;
                job.ApplyDate = DateTime.Now;

                db.ApplyForJobs.Add(job);
                db.SaveChanges();
                ViewBag.Result = "تمت الاضافة بنجاح";
            }
            else
            {
                ViewBag.Result = "المعذرة لقد سبق التقدم لهذة الوظيفة ";
            }       

           


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}