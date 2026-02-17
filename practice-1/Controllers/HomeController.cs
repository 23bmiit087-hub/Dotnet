using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using Microsoft.AspNetCore.Mvc;
using practice_1.Models;

namespace practice_1.Controllers;

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

    public IActionResult Add(int Num1 , int Num2)
    {
        ViewData["Num1"]=Num1;
        ViewData["Num2"]=Num2;
        return View();
    }
    public IActionResult Sub(int Num1 , int Num2)
    {
        ViewData["Num1"]=Num1;
        ViewData["Num2"]=Num2;
        return View();
    }
    public IActionResult Mul(int Num1 , int Num2)
    {
        ViewData["Num1"]=Num1;
        ViewData["Num2"]=Num2;
        return View();
    }
    public IActionResult Div(int Num1 , int Num2)
    {
        ViewData["Num1"]=Num1;
        ViewData["Num2"]=Num2;
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
