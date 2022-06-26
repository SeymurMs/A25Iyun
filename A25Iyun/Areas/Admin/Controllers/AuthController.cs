using Microsoft.AspNetCore.Mvc;

namespace A25Iyun.Areas.Admin.Controllers
{
    public class AuthController : Controller
    {
        [Area("Admin")]
        public IActionResult Register()
        {
            return View();
        }
    }
}
