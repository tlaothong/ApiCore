
using Microsoft.AspNetCore.Mvc;

namespace NetApiCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() {
            return Redirect("swagger");
        }
    }
}