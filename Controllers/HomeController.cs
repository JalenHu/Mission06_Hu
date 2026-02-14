using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Hu.Models;

namespace Mission06_Hu.Controllers;

public class HomeController : Controller
{
    public MovieCollectionContext _context;
    public HomeController(MovieCollectionContext temp)
    {
        _context = temp;
    }
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult GetToKnowJoel()
    {
        return View();
    }
    [HttpGet]
    public IActionResult form()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult form(Movie response)
    {
        _context.Movies.Add(response); //Add record to database
        _context.SaveChanges();
        
        return View("Confirmation", response);
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
}