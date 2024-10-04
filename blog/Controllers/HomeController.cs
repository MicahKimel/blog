using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using blog.Models;
using static blog.Models.Constants;

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
    public IActionResult Gallery()
    {
        return View();
    }

    public IActionResult Inquiry(int id)
    {
        ViewData["Name"] = string.Empty;
        ViewData["Description"] = string.Empty;
        ViewData["Posted"] = string.Empty;

        switch (id)
        {
            case 1:
                ViewData["Name"] = KULLU;
                ViewData["Description"] = KULLU_DESCRIPTION;
                break;
            case 2:
                ViewData["Name"] = MANALI;
                ViewData["Description"] = MANALI_DESCRIPTION;
                break;
            case 3:
                ViewData["Name"] = KASOL_AND_MANIKARAN;
                ViewData["Description"] = KASOL_AND_MANIKARAN_DESCRIPTION;
                break;
            case 4:
                ViewData["Name"] = HAMPTA_PASS;
                ViewData["Description"] = HAMPTA_PASS_DESCRIPTION;
                break;
            case 5:
                ViewData["Name"] = SPITI_VALLEY;
                ViewData["Description"] = SPITI_VALLEY_DESCRIPTION;
                break;
            case 6:
                ViewData["Name"] = LADAKH;
                ViewData["Description"] = LADAKH_DESCRIPTION;
                break;
            default:
                break;
        }

        return View();
    }

    [HttpPost]
    public IActionResult Inquiry(string FirstName, string LastName, string Email, string Phone, string TextArea, string Inquiry)
    {
        // Take the model and email
        Console.WriteLine(FirstName + LastName + Email + Phone + TextArea + Inquiry);
        ViewData["Posted"] = "True";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
