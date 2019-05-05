using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
using System.Threading.Tasks;

namespace BusinessLogicInterface
{
    public interface IRoleBusinessLogic
    {
        /// <summary>
        /// GetListRoles
        /// </summary>
        /// <returns>RolesListResponse</returns>
        Task<RolesListResponse> GetListRoles();

        /// <summary>
        /// AddRole
        /// </summary>
        /// <param name="request">ActionRoleRequest</param>
        /// <returns>bool</returns>
        Task<bool> AddRole(ActionRoleRequest request);

        /// <summary>
        /// UpdateRole
        /// </summary>
        /// <param name="request">ActionRoleRequest</param>
        /// <returns>bool</returns>
        Task<bool> UpdateRole(ActionRoleRequest request);

        /// <summary>
        /// DeleteRole
        /// </summary>
        /// <param name="request">ActionRoleRequest</param>
        /// <returns>bool</returns>
        Task<bool> DeleteRole(ActionRoleRequest request);
    }
}