using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace TripTest.Web
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class AuthorizeAttribute : System.Web.Mvc.AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Request.IsAuthenticated)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new
                        {
                            controller = "Error",
                            action = "ShowError",
                            errorMessage = "You do not have sufficient priviliges to view this page."
                        })
                    );
            }
            else
            {
                base.HandleUnauthorizedRequest(filterContext);
            }
        }
    }
}