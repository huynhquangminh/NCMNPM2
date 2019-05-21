using BaseApplication;
using BusinessLogicInterface;
using BusinessLogicInterface.Requests;
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

        /// <summary>
        /// AddListService
        /// </summary>
        /// <returns>bool</returns>
        [HttpPost]
        public IHttpActionResult AddListService(AddListServiceRequest request)
        {
            var result = _businessLogic.AddListService(request);
            return new ActionResult<bool>(result.Result, Request);
        }

        /// <summary>
        /// DeleteItemService
        /// </summary>
        /// <returns>bool</returns>
        [HttpPost]
        public IHttpActionResult DeleteItemService(DeleteItemServiceRequest request)
        {
            var result = _businessLogic.DeleteItemService(request);
            return new ActionResult<bool>(result.Result, Request);
        }

        /// <summary>
        /// UpdateItemService
        /// </summary>
        /// <returns>bool</returns>
        [HttpPost]
        public IHttpActionResult UpdateItemService(UpdateItemServiceRequest request)
        {
            var result = _businessLogic.UpdateItemService(request);
            return new ActionResult<bool>(result.Result, Request);
        }
    }
}
