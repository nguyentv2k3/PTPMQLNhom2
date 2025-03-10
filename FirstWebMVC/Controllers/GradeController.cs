using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;

namespace FirstWebMVC.Controllers
{
    public class GradeController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View(new GradeModel());

        [HttpPost]
        public IActionResult Index(GradeModel model) => View(model);
    }
}
