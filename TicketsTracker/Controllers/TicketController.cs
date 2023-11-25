using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TicketsTracker.Models;

namespace TicketsTracker.Controllers;

public class TicketController : Controller
{
    private readonly ILogger<TicketController> _logger;
    private MyContext _context;
    public TicketController(ILogger<TicketController> logger, MyContext context)
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
