using DataAcceessInterface.Parameter;
using EntityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcceessInterface
{
    public interface IRoomDataAccess
    {
        /// <summary>
        /// GetRoomList
        /// </summary>
        /// <returns>GET_SERVICE_ALL_Result</returns>
        IEnumerable<GET_LIST_ROOM_Result> GetRoomList();

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
