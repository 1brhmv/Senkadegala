using Microsoft.AspNetCore.Mvc;

namespace Senkadegala.Areas.Admin.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
