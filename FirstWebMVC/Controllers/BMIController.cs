using Microsoft.AspNetCore.Mvc;
using YourNamespace.Models;

namespace YourNamespace.Controllers
{
    public class BMIController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View(new BMIModel());

        [HttpPost]
        public IActionResult Index(BMIModel model) => View(model);
    }
}
