using BaseApplication;
using BusinessLogicInterface;
using BusinessLogicInterface.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net;
using System.Net.Http;

namespace ShopEshopperAPI.Controllers
{
    public class PostsController : ApiController
    {
        private readonly IPostsBusinessLogic _businessLogic;

        public PostsController(IPostsBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }
        /// <summary>
        /// GetRoomList
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult GetPostsList()
        {
            var result = _businessLogic.GetPostsList();
            return new ActionResult<GetPostsResponse>(result.Result, Request);
        }
    }
}