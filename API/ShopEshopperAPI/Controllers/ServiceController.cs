using BaseApplication;
using BusinessLogicInterface;
using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
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

        /// <summary>
        /// GetListServiceTicket
        /// </summary>
        /// <returns>GetListServiceTicketResponse</returns>
        [HttpPost]
        public IHttpActionResult GetListServiceTicket()
        {
            var result = _businessLogic.GetListServiceTicket();
            return new ActionResult<GetListServiceTicketResponse>(result.Result, Request);
        }

        /// <summary>
        /// FindServiceTicket
        /// </summary>
        /// <returns>bool</returns>
        [HttpPost]
        public IHttpActionResult FindServiceTicket(FindServiceTicketRequest request)
        {
            var result = _businessLogic.FindServiceTicket(request);
            return new ActionResult<FindServiceTicketResponse>(result.Result, Request);
        }
    }
}