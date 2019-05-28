using BaseApplication;
using BusinessLogicInterface;
using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
using System.Web.Http;

namespace ShopEshopperAPI.Controllers
{
    public class BookingTicketController : ApiController
    {
        private readonly IBookingTicketBusnessLogic _businessLogic;

        public BookingTicketController(IBookingTicketBusnessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult GetListBookingTicket()
        {
            var result = _businessLogic.GetListBookingTicket();
            return new ActionResult<GetListBookingTicketResponse>(result.Result, Request);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult FindBookingTicket(GetListOrderFromIdentitycardRequest request)
        {
            var result = _businessLogic.GetListOrderFromIdentitycard(request);
            return new ActionResult<GetListOrderFromIdentitycardResponse>(result.Result, Request);
        }

        /// <summary>
        ///InsertBookingTicket
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult InsertBookingTicket(InsertBookingTicketRequest request)
        {
            var result = _businessLogic.InsertBookingTicket(request);
            return new ActionResult<bool>(result.Result, Request);
        }

        /// <summary>
        ///UpdateStatusBookingTicket
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult UpdateStatusBookingTicket(UpdateBookingTicketRequest request)
        {
            var result = _businessLogic.UpdateStatusBookingTicket(request);
            return new ActionResult<bool>(result.Result, Request);
        }

        /// <summary>
        ///DeleteBookingTicket
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult DeleteBookingTicket(DeleteBookingTicketRequest request)
        {
            var result = _businessLogic.DeleteStatusBookingTicket(request);
            return new ActionResult<bool>(result.Result, Request);
        }
    }
}