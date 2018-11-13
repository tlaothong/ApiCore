
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
        [HttpPost]
        public ActionResult<vm.MyApiResponse> RegisterHook(string url) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Register M Content
        /// </summary>
        /// <param name="reg">M content (my registration)</param>
        /// <returns>Nothing</returns>
        [HttpPost("RegMContent")]
        public ActionResult<vm.MyApiResponse> RegisterMContent(vm.MyRegistration reg) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Register a product
        /// </summary>
        /// <param name="reg">A product registration</param>
        [HttpPost("RegProductPage")]
        public ActionResult<vm.MyApiResponse> RegisterProduct(vm.MyProduct reg) {
            throw new NotImplementedException();
        }

        /****
        /// <summary>
        /// Register product and mcontent
        /// </summary>
        /// <param name="mcontent">The m content</param>
        /// <param name="product"></param>
        [HttpPost("RegProductMContent")]
        public ActionResult<vm.MyApiResponse> RegisterProductAndMContent(vm.MyRegistration mcontent, vm.MyProduct product) {
            throw new NotImplementedException();
        }
        ****/

        /// <summary>
        /// The register product form
        /// </summary>
        /// <param name="form">The form te be registered</param>
        [HttpPost("RegProductForm")]
        public ActionResult<vm.MyApiResponse> RegisterProductForm(vm.MyRegisterForm form) {
            throw new NotImplementedException();
        }
    }
}