using College_Management.Models;
using Microsoft.AspNetCore.Mvc;

namespace College_Management.Controllers
{
    public class ComplainController : Controller
    {
        private readonly CollegeManagementProjectContext context;

        public ComplainController(CollegeManagementProjectContext context)
        {
            this.context = context;
        }
        public IActionResult AddComplain()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddComplain(TblComplane cmp)
        {
            if(ModelState.IsValid==true) 
            {
                if(cmp == null)
                {
                    return RedirectToAction("PageNotFound");
                }
                context.TblComplanes.Add(cmp);
               var a= context.SaveChanges();
                if(a>0)
                {
                    TempData["InsertContact"] = "Submitted Data!!";
                    return RedirectToAction("AddComplain","Complain");
                }
            
            }
            return View();
        }

        public IActionResult Details(int id)
        {
            if (HttpContext.Session.GetString("my_session") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            if (id == null || context.TblComplanes == null)
            {
                return RedirectToAction("PageNotFound");
            }
            var data = context.TblComplanes.Where(model => model.CmId == id).FirstOrDefault();
            if (data == null)
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
                var row = context.TblComplanes.Where(model => model.CmId == id).FirstOrDefault();
                if (row != null)
                {
                    context.Entry(row).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                    var a = context.SaveChanges();
                    if (a > 0)
                    {
                        TempData["Datadeleted"] = "Deleted Data!!! ";
                        return RedirectToAction("Index");

                    }

                }
            }


            return View();
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("my_session") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var data = context.TblComplanes.ToList();
            return View(data);
        }
    }
}
