
using Microsoft.AspNetCore.Mvc;

namespace NetApiCore.Controllers
{
    /// <summary>
    /// Nothing home
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Just redirect to swagger
        /// </summary>
        /// <returns>Swagger redirection</returns>
        public IActionResult Index() {
            return Redirect("swagger");
        }
    }
}