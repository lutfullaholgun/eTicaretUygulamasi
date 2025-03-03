using Microsoft.AspNetCore.Mvc;

namespace eTicaretUygulamasi.Areas.Admin.Controllers
{
    public class MainController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}