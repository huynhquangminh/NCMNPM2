using BaseApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicInterface.Dtos;

namespace BusinessLogicInterface.Response
{
    public class GetServiceListResponse:BaseResponse
    {
        public List<GetServiceListDTO> ListService { get; set; }
    }
}
