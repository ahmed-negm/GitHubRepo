using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using RadarcOnline.App.Presentation.Mvc.Extensions.ModelBinders;

namespace RadarcOnline.App.Presentation.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            ViewEngineConfig.SetupViewEngines();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
			BinderConfig.RegisterModelBinders();

        }

        protected void Application_AcquireRequestState(object sender, System.EventArgs e)
        {
            // Globalization
            // Change this if you want to add a new culture
            string[] acceptedCultures = new string[] { "es-ES", "en-US" };
            IEnumerable<CultureInfo> cultures = acceptedCultures.Select(c => new CultureInfo(c));

            if (HttpContext.Current.Session != null)
            {
                RouteData route = HttpContext.Current.Request.RequestContext.RouteData;
                var lang = HttpContext.Current.Request.QueryString["lang"];

                if (lang != null && !string.IsNullOrEmpty(lang.ToString()))
                {
                    Culture = CultureInfo.CreateSpecificCulture(lang);
                }
                else if (Culture == null)
                {
                    IEnumerable<CultureInfo> preferredCultures = HttpContext.Current.Request.UserLanguages.Select(c => new CultureInfo(c.Split(';')[0]));

                    foreach (CultureInfo preferredCulture in preferredCultures)
                    {
                        // Find exact culture
                        Culture = cultures.FirstOrDefault(c => c.Equals(preferredCulture));

                        // Find two letters culture
                        if (Culture == null)
                            Culture = cultures.FirstOrDefault(c => c.TwoLetterISOLanguageName == preferredCulture.TwoLetterISOLanguageName);

                        // Culture found
                        if (Culture != null)
                            break;
                    }

                    // Default culture
                    if (Culture == null)
                        Culture = cultures.First();
                }
                Thread.CurrentThread.CurrentUICulture = Culture;
                Thread.CurrentThread.CurrentCulture = Culture;
            }
        }

		private void Application_Error(object sender, EventArgs e)
        {
            Server.ClearError();
            Response.Redirect("~/Home/Error");
        }

        private CultureInfo Culture
        {
            get
            {
                return HttpContext.Current.Session["Culture"] as CultureInfo;
            }
            set
            {
                HttpContext.Current.Session["Culture"] = value;
            }
        }
    }
}