using College_Management.Models;
using Microsoft.AspNetCore.Mvc;

namespace College_Management.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly CollegeManagementProjectContext context;

        public FeedbackController(CollegeManagementProjectContext context)
        {
            this.context = context;
        }
        public IActionResult FeedbackCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FeedbackCreate(TblFeedback fb)
        {
            if(ModelState.IsValid==true) 
            {
                context.TblFeedbacks.Add(fb);
               var a= context.SaveChanges();
                if(a>0)
                {
                    ModelState.Clear();
                    TempData["fbresult"] = "Submitted";
                }
            }
            return View();
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("my_session") == null)
            {
               return RedirectToAction("Index","Home");
            }
            var data=context.TblFeedbacks.ToList();
            return View(data);
        }

        public IActionResult Details(int id)
        {
            if (HttpContext.Session.GetString("my_session") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            if(id==null || context.TblFeedbacks==null)
            {
                return RedirectToAction("PageNotFound");
            }
            var data = context.TblFeedbacks.Where(model => model.FbId == id).FirstOrDefault();
            if (data==null)
            {
                return RedirectToAction("PageNotFound");
            }
          
            return View(data);
        }

        public IActionResult Delete(int id)
        {
            if (HttpContext.Session.GetString("my_session") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            if (id > 0)
            {
                var row = context.TblFeedbacks.Where(model => model.FbId == id).FirstOrDefault();
                if (row != null)
                {
                    context.Entry(row).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                    var a = context.SaveChanges();
                    if(a>0)
                    {
                        TempData["Datadeleted"] = "Deleted Data!!! ";
                        return RedirectToAction("Index");

                    }

                }
            }


            return View();
        }
    }
}
