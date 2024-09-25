using Microsoft.AspNetCore.Mvc;
using OnatrixCMS.ViewModels;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;

namespace OnatrixCMS.Controllers
{
    public class RiskFormController : SurfaceController
    {
        public RiskFormController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
        }

        public IActionResult RiskSubmit(RiskFormViewModel model)
        {
            if (!ModelState.IsValid)
            {

                return CurrentUmbracoPage();
            }
            ViewData["success"] = "Form submitted successfully.";
            return CurrentUmbracoPage();
        }
    }
}
