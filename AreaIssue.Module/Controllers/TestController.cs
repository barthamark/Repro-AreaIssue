using Microsoft.AspNetCore.Mvc;

namespace AreaIssue.Module.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}