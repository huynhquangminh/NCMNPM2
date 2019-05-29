using BaseApplication;
using BusinessLogicInterface.Dtos;
using System.Collections.Generic;

namespace BusinessLogicInterface.Response
{
    public class GetListBookRoomResponse : BaseResponse
    {
        public List<GetListBookRoomDto> ListBookRoomp { get; set; }
    }
}