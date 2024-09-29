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
    public IActionResult Gallery()
    {
        return View();
    }

    public IActionResult Inquiry(int id)
    {
        switch (id)
        {
            case 0:
                ViewData["Name"] = "";
                ViewData["Description"] = "";
                ViewData["Posted"] = "";
                break;
            case 1:
                ViewData["Name"] = "Kullu";
                ViewData["Description"] = "Kullu, nestled amidst the majestic Himalayas, offers a breathtaking blend of natural beauty, cultural richness, and thrilling outdoor adventures. A Kullu travel package, inclusive of air travel, taxi services, hotel accommodations, fly fishing, and other activities, presents an unforgettable experience for travelers seeking a harmonious escape.";
                ViewData["Posted"] = "";
                break;
            case 2:
                ViewData["Name"] = "Manali";
                ViewData["Description"] = "Manali, nestled amidst the majestic Himalayas, offers a breathtaking blend of natural beauty, cultural richness, and thrilling outdoor adventures. A Manali travel package, inclusive of air travel, taxi services, hotel accommodations, fly fishing, and other activities, presents an unforgettable experience for travelers seeking a harmonious escape";
                ViewData["Posted"] = "";
                break;
            case 3:
                ViewData["Name"] = "Kasol and Manikaran";
                ViewData["Description"] = "Kasol and Manikaran, nestled amidst the picturesque Parvati Valley in Himachal Pradesh, offer a serene escape into the lap of nature. A travel package to these destinations, inclusive of air travel, taxi services, hotel accommodations, fly fishing, and other activities, presents an unforgettable experience for adventure seekers and nature lovers.";
                ViewData["Posted"] = "";
                break;
            case 4:
                ViewData["Name"] = "Hampta Pass";
                ViewData["Description"] = "Hampta Pass is a challenging yet rewarding trek in the Pir Panjal Range of the Himalayas. A travel package to this destination, inclusive of air travel, taxi services, hotel accommodations, fly fishing, and other activities, offers an unforgettable experience for adventure enthusiasts seeking to conquer a high-altitude pass.";
                ViewData["Posted"] = "";
                break;
            case 5:
                ViewData["Name"] = "Spiti";
                ViewData["Description"] = "Spiti Valley, often referred to as the 'Little Tibet of India', offers a unique and unforgettable experience for travelers seeking a blend of adventure, culture, and breathtaking landscapes. A travel package to Spiti Valley, inclusive of air travel, taxi services, hotel accommodations, fly fishing, and other activities, presents an ideal opportunity to explore this remote and mystical region.";
                ViewData["Posted"] = "";
                break;
            case 6:
                ViewData["Name"] = "Ladakh";
                ViewData["Description"] = "Ladakh, often referred to as the 'Land of High Passes', offers a unique and unforgettable experience for adventure enthusiasts seeking to explore the remote and mystical regions of the Himalayas. A travel package to Ladakh, inclusive of air travel, taxi services, hotel accommodations, fly fishing, and other activities, presents an ideal opportunity to embark on a high-altitude adventure.";
                ViewData["Posted"] = "";
                break;
            default:
                ViewData["Name"] = "";
                ViewData["Description"] = "";
                ViewData["Posted"] = "";
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
