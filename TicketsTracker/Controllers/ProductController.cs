using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TicketsTracker.Models;
namespace TicketsTracker.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;
    private MyContext _context;
    public ProductController(ILogger<ProductController> logger, MyContext context)
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
