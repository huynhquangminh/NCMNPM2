using BaseApplication;
using BusinessLogicInterface.Dtos;
using System.Collections.Generic;

namespace BusinessLogicInterface.Response
{
    public class GetRoomAllResponse : BaseResponse
    {
        public List<GetRoomAllDTO> ListRoomAll { get; set; }
    }
}