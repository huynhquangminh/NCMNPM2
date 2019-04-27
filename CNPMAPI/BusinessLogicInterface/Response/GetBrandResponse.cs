using BaseApplication;
using BusinessLogicInterface.Dtos;
using System.Collections.Generic;

namespace BusinessLogicInterface.Response
{
    public class GetBrandResponse : BaseResponse
    {
        public List<GetBrandDto> ListBrand { get; set; }
    }
}