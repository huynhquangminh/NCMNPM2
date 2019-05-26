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
        /// SetBookingRoom
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult SetBookingRoom(SetBookingRoomRequest request)
        {
            var result = _businessLogic.SetBookingRoom(request);
            return new ActionResult<bool>(result.Result, Request);
        }

        /// <summary>
        /// UpdateBookingRoom
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult UpdateBookingRoom(UpdateBookingRoomRequest request)
        {
            var result = _businessLogic.UpdateBookingRoom(request);
            return new ActionResult<bool>(result.Result, Request);
        }

    }
}