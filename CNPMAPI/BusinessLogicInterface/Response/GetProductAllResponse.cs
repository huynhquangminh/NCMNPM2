using BaseApplication;
using BusinessLogicInterface.Dtos;
using System.Collections.Generic;

namespace BusinessLogicInterface.Response
{
    public class GetProductAllResponse : BaseResponse
    {
        public List<GetProductAllDto> ListProductAll { get; set; }
    }
}