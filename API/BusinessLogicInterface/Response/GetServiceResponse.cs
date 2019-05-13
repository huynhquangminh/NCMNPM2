using BaseApplication;
using BusinessLogicInterface.Dtos;
using System.Collections.Generic;

namespace BusinessLogicInterface.Response
{
    public class GetServiceResponse : BaseResponse
    {
        public List<GetServiceDTO> ListServiceAll { get; set; }
    }
}