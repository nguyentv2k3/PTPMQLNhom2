using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;

namespace FirstWebMVC.Controllers
{
    public class BMIController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View(new BMIModel());

        [HttpPost]
        public IActionResult Index(BMIModel model) => View(model);
    }
}
