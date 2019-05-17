using BaseApplication;
using BusinessLogicInterface;
using BusinessLogicInterface.Requests;
using System.Web.Http;

namespace ShopEshopperAPI.Controllers
{
    public class MailController : ApiController
    {
        private readonly IMailBusinessLogic _businessLogic;

        public MailController(IMailBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        /// <summary>
        /// SendMail
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult SendMail(SendMailCommentCustomerRequest RequestData)
        {
            var result = _businessLogic.SendMailCommentCustomer(RequestData);
            return new ActionResult<bool>(result.Result, Request);
        }
    }
}