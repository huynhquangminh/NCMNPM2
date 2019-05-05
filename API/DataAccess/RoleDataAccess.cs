using DataAcceessInterface;
using DataAcceessInterface.Parameter;
using EntityData;
using System.Collections.Generic;

namespace DataAccess
{
    public class RoleDataAccess : IRoleDataAccess
    {
        private ConnectionStringDBShop db = new ConnectionStringDBShop();

        public IEnumerable<GET_LIST_ROLE_Result> GetListRoles()
        {
            return db.GET_LIST_ROLE();
        }

        public void AddRoles(AddRoleParameter param)
        {
            db.INSERT_ROLES(param.RoleName);
        }

        public void UpdateRoles(UpdateRoleParameter param)
        {
            db.UPDATE_ROLES(param.ID, param.RoleName);
        }

        public void DeleteRoles(DeleteRoleParameter param)
        {
            db.DELETE_ROLES(param.ID);
        }
    }
}