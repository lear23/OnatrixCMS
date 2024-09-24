using Microsoft.AspNetCore.Mvc;
using OnatrixCMS.ViewModels;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;

namespace OnatrixCMS.Controllers;

public class ContactSurfaceController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : SurfaceController(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
{


    [HttpPost]
    public IActionResult HandleSubmit(ContactFormViewModel form)
    {


        if (!ModelState.IsValid)
        {
            

            return CurrentUmbracoPage();
        }


        ViewData["success"] = "Form submitted successfully.";
        return CurrentUmbracoPage();
    }

}



//ViewData["name"] = form.Name;
            //ViewData["phone"] = form.Phone;
            //ViewData["email"] = form.Email;
            //ViewData["service"] = form.Service;

            //ViewData["error_name"] = string.IsNullOrEmpty(form.Name);
            //ViewData["error_phone"] = string.IsNullOrEmpty(form.Phone);
            //ViewData["error_email"] = string.IsNullOrEmpty(form.Email);
            //ViewData["error_service"] = string.IsNullOrEmpty(form.Service);