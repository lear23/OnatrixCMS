using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnatrixCMS.Contexts;
using OnatrixCMS.ViewModels;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;


namespace OnatrixCMS.Controllers;

public class ContactSurfaceController : SurfaceController
{
    private readonly ApplicationDbContext _dbContext; 

    public ContactSurfaceController(
        IUmbracoContextAccessor umbracoContextAccessor,
        IUmbracoDatabaseFactory databaseFactory,
        ServiceContext services,
        AppCaches appCaches,
        IProfilingLogger profilingLogger,
        IPublishedUrlProvider publishedUrlProvider,
        ApplicationDbContext dbContext)
        : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {
        _dbContext = dbContext; 
    }

    [HttpPost]
    public IActionResult HandleSubmit(ContactFormViewModel form)
    {

        if (!ModelState.IsValid)
        {
            return CurrentUmbracoPage();
        }


        var contactForm = new ContactFormViewModel
        {
            Name = form.Name,
            Email = form.Email,
            Phone = form.Phone,
            Service = form.Service
        };

        _dbContext.ContactForms.Add(contactForm);
        _dbContext.SaveChanges();

        ViewData["success"] = "Form submitted successfully.";
        return CurrentUmbracoPage();
    }


    [HttpPost]
    public IActionResult HomeSubmit(ContactFormViewModel form)
    {
        if (!ModelState.IsValid)
        {
            return CurrentUmbracoPage();
        }

        
        var contactForm = new ContactFormViewModel
        {
            Name = form.Name,
            Email = form.Email,
            Phone = form.Phone,
            Service = form.Service
        };

        _dbContext.ContactForms.Add(contactForm); 
        _dbContext.SaveChanges();

        ViewData["success"] = "Form submitted successfully.";
        return CurrentUmbracoPage();
    }



}


