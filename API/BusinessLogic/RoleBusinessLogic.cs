using AutoMapper;
using BaseApplication;
using BusinessLogicInterface;
using BusinessLogicInterface.Dtos;
using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
using DataAcceessInterface;
using DataAcceessInterface.Parameter;
using EntityData;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class RoleBusinessLogic : BaseBusinessLogic, IRoleBusinessLogic
    {
        private readonly IRoleDataAccess _dataAccess;

        public RoleBusinessLogic(IRoleDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
            ConfigAutoMapper();
        }

        /// <summary>
        /// ConfigAutoMapper
        /// </summary>
        public override void ConfigAutoMapper()
        {
            configMap = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<GET_LIST_ROLE_Result, RolesListDto>();
            });
            mapper = configMap.CreateMapper();
        }

        /// <summary>
        /// GetListRoles
        /// </summary>
        /// <returns>RolesListResponse</returns>
        public async Task<RolesListResponse> GetListRoles()
        {
            var response = new RolesListResponse();
            try
            {
                var result = _dataAccess.GetListRoles();
                if (result != null)
                {
                    response.listRoles = MapList<GET_LIST_ROLE_Result, RolesListDto>(result.ToList());
                    response.Success = true;
                }
            }
            catch (Exception )
            {
                response.Success = false;
            }
            return await Task.FromResult(response);
        }

        /// <summary>
        /// AddRole
        /// </summary>
        /// <param name="request">ActionRoleRequest</param>
        /// <returns>bool</returns>
        public async Task<bool> AddRole(ActionRoleRequest request)
        {
            bool result = false;
            try
            {
                var param = new AddRoleParameter()
                {
                    RoleName = request.RoleName
                };
                _dataAccess.AddRoles(param);
                result = true;
                return await Task.FromResult(result);
            }
            catch (Exception )
            {
                result = false;
                return await Task.FromResult(result);
            }
            
        }

        /// <summary>
        /// UpdateRole
        /// </summary>
        /// <param name="request">ActionRoleRequest</param>
        /// <returns>bool</returns>
        public async Task<bool> UpdateRole(ActionRoleRequest request)
        {
            bool result = false;
            try
            {
                var param = new UpdateRoleParameter()
                {
                    ID = request.ID,
                    RoleName = request.RoleName
                };
                _dataAccess.UpdateRoles(param);
                result = true;
                return await Task.FromResult(result);
            }
            catch (Exception )
            {
                result = false;
                return await Task.FromResult(result);
            }
           
        }

        /// <summary>
        /// DeleteRole
        /// </summary>
        /// <param name="request">ActionRoleRequest</param>
        /// <returns>bool</returns>
        public async Task<bool> DeleteRole(ActionRoleRequest request)
        {
            bool result = false;
            try
            {
                var param = new DeleteRoleParameter()
                {
                    ID = request.ID
                };
                _dataAccess.DeleteRoles(param);
                result = true;
                return await Task.FromResult(result);
            }
            catch (Exception )
            {
                result = false;
                return await Task.FromResult(result);
            }
           
        }
    }
}