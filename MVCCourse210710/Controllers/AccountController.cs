using MVCCourse210710.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCCourse210710.Controllers
{
    public class AccountController : BaseController
    {
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel login, string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                FormsAuthentication.RedirectFromLoginPage(login.Username, false);

                if (String.IsNullOrEmpty(ReturnUrl))
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    if (!ReturnUrl.StartsWith("/"))
                    {
                        return new HttpStatusCodeResult(401);
                    }

                    return Redirect(ReturnUrl);
                }
            }

            return View();
        }

        [AllowAnonymous]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

    }
}
