using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
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
        Task<bool> DeleteBookRoom(DeleteBookRoomRequest request);
    }
}