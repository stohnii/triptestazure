using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Web.Mvc;

namespace TripTest.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Roles()
        {
            ClaimsIdentity claimsId = ClaimsPrincipal.Current.Identity as ClaimsIdentity;
            var appRoles = new List<String>();
            if (claimsId != null)
            {
                foreach (Claim claim in ClaimsPrincipal.Current.FindAll(claimsId.RoleClaimType))
                    appRoles.Add(claim.Value);
            }
            ViewData["appRoles"] = appRoles;
            return View();
        }
    }
}