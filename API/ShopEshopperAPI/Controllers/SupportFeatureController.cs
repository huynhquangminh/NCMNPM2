using BaseApplication;
using BusinessLogicInterface;
using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
using System.Web.Http;

namespace ShopEshopperAPI.Controllers
{
    public class SupportFeatureController : ApiController
    {
        private readonly ISupportFeatureBusinessLogic _businessLogic;

        public SupportFeatureController(ISupportFeatureBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        /// <summary>
        /// GetInfoWebSite
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult GetInfoWebSite()
        {
            var result = _businessLogic.GetInfoWebSite();
            return new ActionResult<SupportFeatureResponse>(result.Result, null);
        }

        /// <summary>
        /// SendMailCustomer
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult SendMailCustomer(SendMailCommentCustomerRequest RequestData )
        {
            var result = _businessLogic.SendMailCommentCustomer(RequestData);
            return new ActionResult<bool>(result.Result, Request);
        }
    }
}