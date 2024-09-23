using Microsoft.AspNetCore.Mvc;

namespace FutureLightCenter.Controllers;

public class AboutUsController : Controller
{
    private readonly ILogger<AboutUsController> _logger;

    public AboutUsController(ILogger<AboutUsController> logger)
    {
        _logger = logger;
    }
    
    public IActionResult Index()
    {
        return View();
    }
}