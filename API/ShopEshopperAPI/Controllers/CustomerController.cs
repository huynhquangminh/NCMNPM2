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
    public class CustomerController : ApiController
    {
        private readonly ICustomerBusinessLogic _businessLogic;

        public CustomerController(ICustomerBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        /// <summary>
        /// GetCategoryAll
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult GetCustomerAll()
        {
            var result = _businessLogic.GetListCustomers();
            return new ActionResult<GetListCustomerResponse>(result.Result, Request);
        }


        /// <summary>
        /// GetCategoryAll
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult AddCustomer(InsertCustomerRequest request)
        {
            var result = _businessLogic.AddCustomer(request);
            return new ActionResult<bool>(result.Result, Request);
        }


        /// <summary>
        /// EditCategory
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult UpdateCustomer(UpdateCustomerRequest request)
        {
            var result = _businessLogic.UpdateCustomer(request);
            return new ActionResult<bool>(result.Result, Request);
        }


        /// <summary>
        /// DeleteCategory
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult DeleteCustomer(DeleteCustomerRequest request)
        {
            var result = _businessLogic.DeleteCustomer(request);
            return new ActionResult<bool>(result.Result, Request);
        }
    }
}
