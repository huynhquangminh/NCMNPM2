using BaseApplication;
using BusinessLogicInterface.Dtos;
using System.Collections.Generic;

namespace BusinessLogicInterface.Response
{
    public class RolesListResponse : BaseResponse
    {
        public List<RolesListDto> listRoles { get; set; }
    }
}