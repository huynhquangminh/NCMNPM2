using BaseApplication;
using BusinessLogicInterface;
using BusinessLogicInterface.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShopEshopperAPI.Controllers
{
    public class ServiceController : ApiController
    {
        private readonly IServiceBusinessLogic _businessLogic;

        public ServiceController(IServiceBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        /// <summary>
        /// GetServiceAll
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult GetServiceAll()
        {
            var result = _businessLogic.GetServiceAll();
            return new ActionResult<GetServiceResponse>(result.Result, Request);
        }

    }
}
