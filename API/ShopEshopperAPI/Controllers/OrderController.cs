using BaseApplication;
using BusinessLogicInterface;
using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
using System.Web.Http;

namespace ShopEshopperAPI.Controllers
{
    public class OrderController : ApiController
    {
        private readonly IOrderBusinessLogic _businessLogic;

        public OrderController(IOrderBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }
    }
}