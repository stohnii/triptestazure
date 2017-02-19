using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OpenIdConnect;
using System.Web;
using System.Web.Mvc;

namespace TripTest.Web.Controllers
{
    public class AccountController : Controller
    {
        public void SignIn(string redirectUri)
        {
            if (redirectUri == null)
                redirectUri = "/";

            HttpContext.GetOwinContext().Authentication.Challenge(new AuthenticationProperties { RedirectUri = redirectUri }, OpenIdConnectAuthenticationDefaults.AuthenticationType);
        }

        public void SignOut()
        {
            if (Request.IsAuthenticated)
            {
                HttpContext.GetOwinContext().Authentication.SignOut(OpenIdConnectAuthenticationDefaults.AuthenticationType, CookieAuthenticationDefaults.AuthenticationType);
            }
        }

        public void EndSession()
        {
            HttpContext.GetOwinContext().Authentication.SignOut(CookieAuthenticationDefaults.AuthenticationType);
        }
    }
}