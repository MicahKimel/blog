using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using blog.Models;

namespace blog.Controllers;

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

    public IActionResult Packages()
    {
        return View();
    }

    public IActionResult Inquiry()
    {
        ViewData["Name"] = "Kullu";
        ViewData["Description"] = "Kullu";
        return View();
    }

    [HttpPost]
    public IActionResult YourAction(string Name, string Email)
    {
        // Process the form data here
        // ...

        return View("Index"); // Or redirect to another view
    }

    [HttpPost]
    public IActionResult Inquiry(string FirstName, string LastName, string Email, string Phone, string TextArea)
    {
        // Take the model and email
        Console.WriteLine(FirstName + LastName + Email + Phone + TextArea);
        return View("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
