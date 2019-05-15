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

        /// <summary>
        /// GetServiceAll
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpGet]
        public IHttpActionResult GetRoomList()
        {
            var result = _businessLogic.GetRoomList();
            return new ActionResult<GetListRoomResponse>(result.Result, Request);
        }

        /// <summary>
        /// GetServiceAll
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpGet]
        public IHttpActionResult GetSeriveList()
        {
            var result = _businessLogic.GetServiceList();
            return new ActionResult<GetServiceListResponse>(result.Result, Request);
        }
    }
}
