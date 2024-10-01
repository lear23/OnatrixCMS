using Microsoft.AspNetCore.Mvc;
using OnatrixCMS.Contexts;
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
    public class RiskSurfaceController : SurfaceController
    {
        private readonly ApplicationDbContext _dbContext;

        public RiskSurfaceController(
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
        public IActionResult RiskSubmit(RiskFormViewModel model)
        {
            if (ModelState.IsValid)
            {
                
                var riskForm = new RiskFormViewModel
                {
                    Name = model.Name,
                    Email = model.Email,
                    Message = model.Message
                };

                _dbContext.RiskForms.Add(riskForm); 
                _dbContext.SaveChanges(); 

                ViewData["riskSuccess"] = "Form submitted successfully.";
                return CurrentUmbracoPage();
            }

           
            return CurrentUmbracoPage();
        }

        [HttpPost]
        public IActionResult EmailSubmit(EmailViewModel model)
        {
            if (ModelState.IsValid)
            {

                var emailForm = new EmailViewModel
                {
                    Email = model.Email
                };

                _dbContext.EmailForms.Add(emailForm);
                _dbContext.SaveChanges();

              
                return CurrentUmbracoPage();
            }


            return CurrentUmbracoPage();
        }
    }
}
