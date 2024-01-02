using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PairProgramming.Models;
using PairProgramming.Services;

namespace PairProgramming.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IPersonService _personService;

    public HomeController(ILogger<HomeController> logger, IPersonService personService)
    {
        _logger = logger;
        _personService = personService;
    }

    // [Route("tissemand")]
    public IActionResult Index()
    {
        var person = _personService.Create("Nikolaj", "Geisle", "test@email.com", DateTime.Now);
        return View(person);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}