using BaseApplication;
using BusinessLogicInterface.Dtos;
using System.Collections.Generic;

namespace BusinessLogicInterface.Response
{
   public class GetCategoryResponse : BaseResponse
    {
        public List<GetCategoryDto> ListGetCategory { get; set; }
    }
}