using Microsoft.AspNetCore.Mvc;

namespace FutureLightCenter.Controllers;

public class LawController : Controller
{
    private readonly ILogger<LawController> _logger;

    public LawController(ILogger<LawController> logger)
    {
        _logger = logger;
    }
    
    public IActionResult Index()
    {
        return View();
    }
}