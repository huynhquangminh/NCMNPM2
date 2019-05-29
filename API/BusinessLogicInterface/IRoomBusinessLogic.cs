using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
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
        /// GetRoom all
        /// </summary>
        /// <returns>GetListRoomResponse</returns>
        Task<GetRoomAllResponse> GetRoomAll();

        /// <summary>
        /// AddListRoom
        /// </summary>
        /// <returns>bool</returns>
        Task<bool> AddListRoom(AddListRoomRequest request);

        /// <summary>
        /// GetInfoFromRoomNo
        /// </summary>
        /// <returns>GetInfoFromRoomNoResponse</returns>
        Task<GetInfoFromRoomNoResponse> GetInfoFromRoomNo(GetInfoFromRoomNoRequest request);

        /// <summary>
        /// GetListRoomFromDate
        /// </summary>
        /// <returns>GetListRoomFromDateResponse</returns>
        Task<GetListRoomFromDateResponse> GetListRoomFromDate(GetListRoomFromDateRequest request);
    }
}