using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using quiz.Models;

namespace quiz.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult start_quiz(){
        return View();
    }

    public IActionResult question1(String txtName, String txtEmail , int txtPhone , String txtcity , String txtGender , String txtSubject){
        return Content(txtName);
    }

    public IActionResult question2(){
        return View();
    }

    public IActionResult question3(){
        return View();
    }

    public IActionResult question4(){
        return View();
    }

    public IActionResult end_exam(){
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
