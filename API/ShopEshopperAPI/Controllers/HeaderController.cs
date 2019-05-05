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
    public class HeaderController : ApiController
    {
        private readonly IHeaderBusinessLogic _businessLogic;

        public HeaderController(IHeaderBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        /// <summary>
        /// GetListNewsAll
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult GetHeader()
        {
            var result = _businessLogic.GetListHeader();
            return new ActionResult<GetListHeaderResponse>(result.Result, Request);
        }
    }
}
