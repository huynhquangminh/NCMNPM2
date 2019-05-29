using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicInterface
{
    public interface IOrderBusinessLogic
    {
     
        /// <summary>
        /// SetBookingRoomRequest
        /// </summary>
        /// <returns>bool</returns>
        Task<bool> SetBookingRoom(SetBookingRoomRequest request);

        /// <summary>
        /// UpdateBookingRoom
        /// </summary>
        /// <returns>bool</returns>
        Task<bool> UpdateBookingRoom(UpdateBookingRoomRequest request);

        Task<GetListBookRoomResponse> GetBookRoomAll();

        Task<GetListBookRoomResponse> FindBookRoom(FindBookRoomRequest request);
    }
}
