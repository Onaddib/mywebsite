using Microsoft.AspNetCore.Mvc;
using Models.Models;
using System.Diagnostics;

namespace MyWebSite.Controllers
{
    public class HomeController : Controller
    {/*
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult MyProjects()
        {
            return View();
        }

        public IActionResult AboutMe()
        {
            return View();
        }
        
        public IActionResult Blogs()
        {
            return View();
        }
        
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Blog blog)
        {
            var Blogs = new Blog
            {
                Title = blog.Title,
                Content = blog.Title,
                ID = blog.ID,
                Description = blog.Description,
                CreatedDate = blog.CreatedDate,
                Image = blog.Image,

            };
        }
        
    
    }
}