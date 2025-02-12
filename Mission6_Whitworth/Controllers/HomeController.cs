using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6_Whitworth.Models;

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
        return View("movieForm");
    }

    [HttpPost]
    public IActionResult MovieForm(movieFormClass response)
    {
        _context.Movies.Add(response);
        _context.SaveChanges();
        return View("formConfirmation", response);
    }
    
}