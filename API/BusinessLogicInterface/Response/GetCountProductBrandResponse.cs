using BaseApplication;
using BusinessLogicInterface.Dtos;
using System.Collections.Generic;

namespace BusinessLogicInterface.Response
{
    public class GetCountProductBrandResponse : BaseResponse
    {
        public List<GetCountProductBrandDto> ListCount { get; set; }
    }
}