using BaseApplication;
using BusinessLogicInterface.Dtos;
using System.Collections.Generic;

namespace BusinessLogicInterface.Response
{
    public class FindProductResponse : BaseResponse
    {
        public List<FindProductDto> ListProduct { get; set; }
    }
}