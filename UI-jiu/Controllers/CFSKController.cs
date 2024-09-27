using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class CFSKController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
