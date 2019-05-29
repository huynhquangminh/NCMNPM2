using DataAcceessInterface;
using DataAcceessInterface.Parameter;
using EntityData;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class RoomDataAccess : IRoomDataAccess
    {
        private HotelDbConnection db = new HotelDbConnection();

        /// <summary>
        /// GetRoomList
        /// </summary>
        /// <returns>GetRoomList</returns>
        public IEnumerable<GET_LIST_ROOM_Result> GetRoomList()
        {
            var tamp = db.GET_LIST_ROOM().ToList();
            return db.GET_LIST_ROOM();
        }

        /// <summary>
        /// get room all
        /// </summary>
        /// <returns>GETROOM_ALL_Result</returns>
        public IEnumerable<GETROOM_ALL_Result> GetRoomAll()
        {
            var tamp = db.GETROOM_ALL();
            return db.GETROOM_ALL();
        }

        /// <summary>
        /// AddListRoom
        /// </summary>
        /// <returns>AddListRoom</returns>
        public void AddListRoom(AddListRoomParameter request)
        {
            db.ADD_LIST_ROOM(request.tenLoaiPhong, request.giaPhong, request.imgLoaiPhong);
        }

        /// <summary>
        /// GetInfoFromRoomNo
        /// </summary>
        /// <returns>GET_INFO_FROM_ROOM_NO_Result</returns>
        public IEnumerable<GET_INFO_FROM_ROOM_NO_Result> GetInfoFromRoomNo(GetInfoFromRoomNoParameter param)
        {
            return db.GET_INFO_FROM_ROOM_NO(param.roomNo);
        }
    }
}