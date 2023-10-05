using Microsoft.AspNetCore.Mvc;

namespace Unidad_2_Actividad_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
