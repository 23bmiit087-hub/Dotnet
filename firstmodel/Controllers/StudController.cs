using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using firstmodel.Models; 

namespace firstmodel.Controllers
{
    [Route("[controller]")]
    [Route("[controller]/[action]")]

    public class StudController : Controller
    {
        private readonly ILogger<StudController> _logger;

        public StudController(ILogger<StudController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Display(Student s)
        {
            return View(s);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}