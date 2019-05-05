using DataAcceessInterface.Parameter;
using EntityData;
using System.Collections.Generic;

namespace DataAcceessInterface
{
    public interface IRoleDataAccess
    {
        IEnumerable<GET_LIST_ROLE_Result> GetListRoles();

        void AddRoles(AddRoleParameter param);

        void UpdateRoles(UpdateRoleParameter param);

        void DeleteRoles(DeleteRoleParameter param);
    }
}