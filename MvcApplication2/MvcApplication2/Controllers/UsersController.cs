using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class UsersController : Controller
    {
        //
        // GET: /Users/

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }


        [HttpPost,ActionName("Login")]
        public ActionResult Login_Check(Models.Users_login loginuser)
        {
            if (ModelState.IsValid && loginuser.Username == loginuser.Password)
            {
                Session.Add("User", loginuser);
                return RedirectToAction("index", "Default");
            }
            return View();
        }

        
        public ActionResult Logout()
        {
            Session.Remove("User");
            return RedirectToAction("index", "Default");
        }
    }
}
