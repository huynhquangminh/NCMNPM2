using BaseApplication;
using BusinessLogicInterface;
using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ShopEshopperAPI.Controllers
{
    public class OrderController:ApiController
    {
        private readonly IOrderBusinessLogic _businessLogic;

        public OrderController(IOrderBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        /// <summary>
        /// GetRoomList
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult GetListOrderFromIdentitycard(GetListOrderFromIdentitycardRequest request)
        {
            var result = _businessLogic.GetListOrderFromIdentitycard(request);
            return new ActionResult<GetListOrderFromIdentitycardResponse>(result.Result, Request);
        }

    }
}