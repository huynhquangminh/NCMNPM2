using BaseApplication;
using BusinessLogicInterface.Dtos;
using System.Collections.Generic;

namespace BusinessLogicInterface.Response
{
    public class GetNewsAllResponse : BaseResponse
    {
        public List<GetNewsAllDto> listNewsAll { get; set; }
    }
}