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
    public class RoomController : ApiController
    {
        private readonly IRoomBusinessLogic _businessLogic;

        public RoomController(IRoomBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }
        /// <summary>
        /// GetRoomList
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult GetRoomList()
        {
            var result = _businessLogic.GetRoomList();
            return new ActionResult<GetListRoomResponse>(result.Result, Request);
        }

        /// <summary>
        /// AddListRoom
        /// </summary>
        /// <returns>bool</returns>
        [HttpPost]
        public IHttpActionResult AddListRoom(AddListRoomRequest request)
        {
            var result = _businessLogic.AddListRoom(request);
            return new ActionResult<bool>(result.Result, Request);
        }
    }
}
