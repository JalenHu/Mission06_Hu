using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission06_Hu.Models;

namespace Mission06_Hu.Controllers;

public class HomeController : Controller
{
    private readonly MovieCollectionContext _context;

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
        ViewBag.Categories = _context.Categories.ToList();   // OR SelectList (see below)
        return View("form", new Movie());
    }

    [HttpPost]
    public IActionResult form(Movie response)
    {
        if (ModelState.IsValid)
        {
            _context.Movies.Add(response); //Add record to database
            _context.SaveChanges();
            
            return View("Confirmation", response);
        }
        else
        {
            ViewBag.Categories = _context.Categories.ToList();
            
            return  View(new Movie());
        }
        
    }

    public IActionResult Privacy()
    {
        return View();
    }

    //Create the rout to movielist
    [HttpGet]
    public IActionResult MovieList()
    {
        var movie = _context.Movies
            .Include(m => m.Category)
            .ToList();
        return View("MovieList", movie);
    }
//Get to form to edit page
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var movieEdit = _context.Movies
            .Single(m => m.MovieId == id);

        ViewBag.Categories = _context.Categories
            .OrderBy(c => c.CategoryName)
            .ToList();
        return View("form", movieEdit);
    }
//Save edit
    [HttpPost]
    public IActionResult Edit(Movie updatemovie)
    {
        if (ModelState.IsValid)
        {
            _context.Update(updatemovie);
            _context.SaveChanges();
            return RedirectToAction("MovieList");
        }

        ViewBag.Categories = _context.Categories
            .OrderBy(c => c.CategoryName)
            .ToList();
        return View("form", updatemovie);
    }
//Get to delete page
    [HttpGet]
    public IActionResult Delete(int id)
    {
        var movieDelete = _context.Movies
            .Single(m => m.MovieId == id);
        return View("Delete", movieDelete);
    }
//Delete Movie
    [HttpPost]
    public IActionResult Delete(Movie deleteMovie)
    {
        _context.Movies.Remove(deleteMovie);
        _context.SaveChanges();
        return RedirectToAction("MovieList");
    }
}