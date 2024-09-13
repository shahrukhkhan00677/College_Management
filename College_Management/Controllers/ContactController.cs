using College_Management.Models;
using Microsoft.AspNetCore.Mvc;

namespace College_Management.Controllers
{
    public class ContactController : Controller
    {
        private readonly CollegeManagementProjectContext contaxt;

        public ContactController(CollegeManagementProjectContext contaxt)
        {
            this.contaxt = contaxt;
        }
        public IActionResult CreateContact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateContact(TblContact con)
        {
            if(ModelState.IsValid==true)
            {
                if(con == null)
                {
                    return RedirectToAction("PageNotFound");
                }
                contaxt.TblContacts.Add(con);
               var a= contaxt.SaveChanges();
                if(a>0)
                {
                    TempData["InsertContact"] = "Submitted Data!!";
                    return RedirectToAction("CreateContact", "Contact");
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
            var data = contaxt.TblContacts.ToList();
            return View(data);
        }

        public IActionResult Details(int id)
        {
            if (HttpContext.Session.GetString("my_session") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            if (id == null || contaxt.TblContacts == null)
            {
                return RedirectToAction("PageNotFound");
            }
            var data = contaxt.TblContacts.Where(model => model.CnId == id).FirstOrDefault();
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
                var row = contaxt.TblContacts.Where(model => model.CnId == id).FirstOrDefault();
                if (row != null)
                {
                    contaxt.Entry(row).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                    var a = contaxt.SaveChanges();
                    if (a > 0)
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
