using BaseApplication;
using BusinessLogicInterface;
using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
using DataAcceessInterface.Parameter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ShopEshopperAPI.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserBusinessLogic _businessLogic;

        public UserController(IUserBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        /// <summary>
        /// UserLogin
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult UserLogin(UserLoginRequest request)
        {
            var result = _businessLogic.UserLogin(request);
            return new ActionResult<UserLoginResponse>(result.Result, Request);
        }

        /// <summary>
        /// UserRegister
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult UserRegister(UserRegisterRequest request)
        {
            var result = _businessLogic.UserRegister(request);
            return new ActionResult<bool>(result.Result, Request);
        }
    }
}