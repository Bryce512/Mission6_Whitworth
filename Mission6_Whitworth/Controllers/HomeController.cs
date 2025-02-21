using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6_Whitworth.Models;
using SQLitePCL;

namespace Mission6_Whitworth.Controllers;

public class HomeController : Controller
{

    private MovieContext _context;
    public HomeController(MovieContext temp)
    {
        _context = temp;
    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
    public IActionResult Info()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult MovieForm()
    {
       ViewBag.Categories =  _context.Categories
            .ToList();
        return View("movieForm");
    }

    [HttpPost]
    public IActionResult MovieForm(Movie response)
    {
        _context.Movies.Add(response);
        _context.SaveChanges();
        return View("formConfirmation", response);
    }

    public IActionResult MovieList()
    {
        var movies = _context.Movies.ToList();

        return View(movies);
    }

    [HttpGet]
    public IActionResult Edit(int movieId)
    {
        Movie movieToEdit = _context.Movies
            .Single(x => x.movieId == movieId);
        
        ViewBag.Categories =  _context.Categories
            .ToList();
        
        return View("MovieForm", movieToEdit);
    }

    [HttpPost]
    public IActionResult Edit(Movie updatedInfo)
    {
        _context.Movies.Update(updatedInfo);
        _context.SaveChanges();

        return RedirectToAction("MovieList");
    }

    [HttpGet]
    public IActionResult Delete(int Id)
    {
        Movie movieToDelete = _context.Movies
            .Single(x => x.movieId == Id); //.single ensures it only finds 1 record
        
        return View("DeleteConfirmation", movieToDelete);
    }

    [HttpPost]
    public IActionResult Delete(Movie movieToDelete)
    {
        _context.Movies.Remove(movieToDelete);
        _context.SaveChanges();
        
        return RedirectToAction("MovieList");
    }
}