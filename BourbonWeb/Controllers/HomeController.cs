using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using BourbonWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace BourbonWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IActionDescriptorCollectionProvider _actions;

        public HomeController(ILogger<HomeController> logger, IActionDescriptorCollectionProvider actions)
        {
            _logger = logger;
            _actions = actions;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult UnderConstruction()
        {
            return View();
        }

        public IActionResult Sitemap()
        {
            var descriptors = _actions.ActionDescriptors.Items
                .OfType<ControllerActionDescriptor>();

            var urls = new List<string>();
            foreach (var d in descriptors)
            {
                var httpMethods = d.ActionConstraints?
                    .OfType<HttpMethodActionConstraint>()
                    .FirstOrDefault()?.HttpMethods;

                if (httpMethods != null && !httpMethods.Contains("GET"))
                {
                    continue;
                }

                var area = d.RouteValues.ContainsKey("area") ? d.RouteValues["area"] : null;
                var url = Url.Action(d.ActionName, d.ControllerName, new { area });
                if (!string.IsNullOrEmpty(url))
                {
                    urls.Add(url);
                }
            }

            return View(urls);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
