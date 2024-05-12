using Microsoft.AspNetCore.Mvc;

namespace CP_POS.Controllers
{
    public class CommonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
