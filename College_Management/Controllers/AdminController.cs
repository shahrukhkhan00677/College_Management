using College_Management.Models;
using Microsoft.AspNetCore.Mvc;

namespace College_Management.Controllers
{
    public class AdminController : Controller
    {
        private readonly CollegeManagementProjectContext context;

        public AdminController(CollegeManagementProjectContext context)
        {
            this.context = context;
        }
        public IActionResult AdminLogin()
        {
            if(HttpContext.Session.GetString("my_context")!=null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public IActionResult AdminLogin(TblAdmin ad)
        {
            if(ModelState.IsValid==true) 
            {
                var data=context.TblAdmins.Where(model=>model.AdUsername==ad.AdUsername && model.AdPassword==ad.AdPassword).FirstOrDefault();
                if(data!=null)
                {
                    HttpContext.Session.SetString("my_session", data.AdUsername);
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.failed = "Enter Correct userName and Password";
                }
            }
            return View();
        }
        public IActionResult AdminLogout()
        {
            if(HttpContext.Session.GetString("my_session")!=null)
            {
                HttpContext.Session.Remove("my_session");
                return RedirectToAction("AdminLogin");
            }
            return View();
        }
        public IActionResult Index()
        {
            if(HttpContext.Session.GetString("my_session")!=null)
            {
                ViewBag.adminName = HttpContext.Session.GetString("my_session");
            }
            else
            {
                return RedirectToAction("AdminLogin");
            }
            return View();
        }
    }
}
