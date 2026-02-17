using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using forms.Models;

namespace forms.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Display(string txtName, string txtEmail, int txtPhone, string txtCity, string txtGender)
    {
        ViewBag.Name = txtName;
        ViewBag.Email = txtEmail;
        ViewBag.Phone = txtPhone;
        ViewBag.City = txtCity;
        ViewBag.Gender = txtGender;

        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
