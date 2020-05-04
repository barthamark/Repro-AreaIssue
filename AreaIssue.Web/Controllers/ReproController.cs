using Microsoft.AspNetCore.Mvc;

namespace AreaIssue.Web.Controllers
{
    public class ReproController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Test", new { Area = "AreaIssue.Module" });
        }
    }
}