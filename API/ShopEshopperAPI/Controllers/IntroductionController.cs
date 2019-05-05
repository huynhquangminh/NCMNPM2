using BaseApplication;
using BusinessLogicInterface;
using BusinessLogicInterface.Response;
using System.Web.Http;

namespace ShopEshopperAPI.Controllers
{
    public class IntroductionController : ApiController
    {
        private readonly IIntroductionBusinessLogic _businessLogic;

        public IntroductionController(IIntroductionBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        /// <summary>
        /// GetIntroduction
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult GetIntroduction()
        {
            var result = _businessLogic.GetIntroduction();
            return new ActionResult<GetIntroductionResponse>(result.Result, Request);
        }
    }
}