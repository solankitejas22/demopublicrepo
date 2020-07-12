using secondsms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace secondsms.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Index(User objchk)
        {
            if (ModelState.IsValid)
            {
                using (stdsyEntities db = new stdsyEntities())
                {
                    var obj = db.Users.Where(a => a.username.Equals(objchk.username) && a.password.Equals(objchk.password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["UserId"] = obj.Id.ToString();
                        Session["Username"]= obj.username.ToString();
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "The User Name or Password is incorrect");
                    }
                    
                }
            }
            return View(objchk);
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Login");
        }


	}
}