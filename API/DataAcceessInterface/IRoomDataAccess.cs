using DataAcceessInterface.Parameter;
using EntityData;
using System.Collections.Generic;

namespace DataAcceessInterface
{
    public interface IRoomDataAccess
    {
        /// <summary>
        /// Get TYPE RoomList
        /// </summary>
        /// <returns>GET_SERVICE_ALL_Result</returns>
        IEnumerable<GET_LIST_ROOM_Result> GetRoomList();

        /// <summary>
        /// Get  Room all
        /// </summary>
        /// <returns>GETROOM_ALL_Result</returns>
        IEnumerable<GETROOM_ALL_Result> GetRoomAll();

        /// <summary>
        /// AddListRoom
        /// </summary>
        /// <returns>void</returns>
        void AddListRoom(AddListRoomParameter param);

        /// <summary>
        /// GetInfoFromRoomNo
        /// </summary>
        /// <returns>GET_INFO_FROM_ROOM_NO_Result</returns>
        IEnumerable<GET_INFO_FROM_ROOM_NO_Result> GetInfoFromRoomNo(GetInfoFromRoomNoParameter param);
    }
}