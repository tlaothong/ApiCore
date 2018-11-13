
using System;
using Microsoft.AspNetCore.Mvc;
using vm = NetApiCore.ViewModels;

namespace NetApiCore.Controllers
{
    /// <summary>
    /// My API Controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MyApiController : ControllerBase
    {
        /// <summary>
        /// Register Hook
        /// </summary>
        /// <param name="url">a simple url string</param>
        /// <returns>my api response</returns>
        [HttpGet]
        public ActionResult<vm.MyApiResponse> RegisterHook(string url) {
            throw new NotImplementedException();
        }
    }
}