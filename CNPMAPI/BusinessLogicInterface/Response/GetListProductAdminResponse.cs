using BaseApplication;
using BusinessLogicInterface.Dtos;
using System.Collections.Generic;

namespace BusinessLogicInterface.Response
{
    public class GetListProductAdminResponse : BaseResponse
    {
        public List<GetListProductAdminDto> ListProductAdmin { get; set; }
        public List<GetCategoryDto> ListCategory { get; set; }
    }
}