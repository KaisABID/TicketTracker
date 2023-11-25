using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TicketsTracker.Models;
namespace TicketsTracker.Controllers;

public class ProjectController : Controller
{
    private readonly ILogger<ProjectController> _logger;
    private MyContext _context;
    public ProjectController(ILogger<ProjectController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }






    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
