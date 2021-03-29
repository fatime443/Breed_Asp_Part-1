using BreedAsp.Data;
using BreedAsp.Models;
using BreedAsp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BreedAsp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;

        public HomeController(ILogger<HomeController> logger, DataContext context)
        {
            _context = context; 
            _logger = logger;
        }

        public IActionResult Index()
        {
            var header = _context.Headers.First();
            var about = _context.AboutSections.First();
            List<Service> services = _context.Services.ToList();
            List<Tesitmonial> tesitmonials = _context.Tesitmonials.ToList();
            List<Blog> blog = _context.Blogs.ToList();
            List<Brands> brands = _context.Brands.ToList();
            HomeVM homeVM = new()
            {
                Header = header,
                AboutSection = about,
                Services = services,
                Tesitmonials = tesitmonials,
                Blogs = blog,
                Brands = brands
            };
            return View(homeVM);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
