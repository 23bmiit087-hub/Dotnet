using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Database_Conn_087.Models;

namespace Database_Conn_087.Controllers;

public class HomeController : Controller
{
    private readonly DatabaseFirstContext dbc;
    public HomeController(DatabaseFirstContext dbc)
    {
        this.dbc = dbc;
    }
    
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Create(Student s)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        dbc.Students.Add(s);
        dbc.SaveChanges();
        return RedirectToAction("Display");
    }
    [HttpGet]
    public IActionResult Display(Student student)
    {
        var students = dbc.Students.ToList();
        return View(students);
    }

    [HttpPost]
    public IActionResult Display(Student student , String search)
    {
        var students = dbc.Students.Where(s=>s.Name.Contains(search)).ToList();
        return View(students);
    }
    
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var stud=dbc.Students.Find(id);
        return View(stud);
    }

    [HttpPost]
    public IActionResult Edit(Student student)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        dbc.Students.Update(student);
        dbc.SaveChanges();
        return RedirectToAction("Display");
    }
   [HttpGet]
    public IActionResult Delete(Student s,int id)
    {
        var del=dbc.Students.Find(id);
        return View(del);
    }
    [HttpPost]
    public IActionResult Delete(int id)
    {
        var st=dbc.Students.FirstOrDefault(s=>s.Id==id);
        dbc.Students.Remove(st);
        dbc.SaveChanges();
        return RedirectToAction("Display");
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
