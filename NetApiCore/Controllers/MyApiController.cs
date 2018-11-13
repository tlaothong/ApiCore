
using System;
using Microsoft.AspNetCore.Mvc;
using vm = NetApiCore.ViewModels;

namespace NetApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyApiController : ControllerBase
    {
        [HttpGet]
        public ActionResult<vm.MyApiResponse> RegisterHook(string url) {
            throw new NotImplementedException();
        }
    }
}