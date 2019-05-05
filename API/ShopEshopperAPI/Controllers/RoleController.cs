using BaseApplication;
using BusinessLogicInterface;
using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
using System.Web.Http;

namespace ShopEshopperAPI.Controllers
{
    public class RoleController : ApiController
    {
        private readonly IRoleBusinessLogic _businessLogic;

        public RoleController(IRoleBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        /// <summary>
        /// GetListRoles
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult GetListRoles()
        {
            var result = _businessLogic.GetListRoles();
            return new ActionResult<RolesListResponse>(result.Result, Request);
        }

        /// <summary>
        /// AddRole
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult AddRole(ActionRoleRequest request)
        {
            var result = _businessLogic.AddRole(request);
            return new ActionResult<bool>(result.Result, Request);
        }

        /// <summary>
        /// UpdateRole
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult UpdateRole(ActionRoleRequest request)
        {
            var result = _businessLogic.UpdateRole(request);
            return new ActionResult<bool>(result.Result, Request);
        }

        /// <summary>
        /// DeleteRoles
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult DeleteRoles(ActionRoleRequest request)
        {
            var result = _businessLogic.DeleteRole(request);
            return new ActionResult<bool>(result.Result, Request);
        }
    }
}