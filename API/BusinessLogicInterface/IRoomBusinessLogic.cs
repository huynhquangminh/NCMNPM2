using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicInterface
{
   public interface IRoomBusinessLogic
    {
        /// <summary>
        /// GetRoomList
        /// </summary>
        /// <returns>GetListRoomResponse</returns>
        Task<GetListRoomResponse> GetRoomList();

        /// <summary>
        /// AddListRoom
        /// </summary>
        /// <returns>bool</returns>
        Task<bool> AddListRoom(AddListRoomRequest request);
    }
}
