using System;
using System.Configuration;
using System.Globalization;

namespace TripTest.Web.Utils
{
    public class ConfigHelper
    {
        private static readonly string aadInstance = ConfigurationManager.AppSettings["ida:AADInstance"];
        private static readonly string clientId = ConfigurationManager.AppSettings["ida:ClientId"];
        private static readonly string appKey = ConfigurationManager.AppSettings["ida:AppKey"];
        private static readonly string graphResourceId = ConfigurationManager.AppSettings["ida:GraphUrl"];
        private static readonly string appTenant = ConfigurationManager.AppSettings["ida:Tenant"];
        private static readonly string graphApiVersion = ConfigurationManager.AppSettings["ida:GraphApiVersion"];
        private static readonly string postLogoutRedirectUri = ConfigurationManager.AppSettings["ida:PostLogoutRedirectUri"];
        private static readonly string commonAuthority = String.Format(CultureInfo.InvariantCulture, aadInstance, "common/");

        public static string ClientId { get { return clientId; } }
        internal static string AppKey { get { return appKey; } }
        internal static string GraphResourceId { get { return graphResourceId; } }
        internal static string GraphApiVersion { get { return graphApiVersion; } }
        internal static string AadInstance { get { return aadInstance; } }
        internal static string PostLogoutRedirectUri { get { return postLogoutRedirectUri; } }
        internal static string CommonAuthority { get { return commonAuthority; } }
        internal static string Tenant { get { return appTenant; } }

    }
}