using DataAcceessInterface;
using DataAcceessInterface.Parameter;
using EntityData;
using System.Collections.Generic;

namespace DataAccess
{
    public class OrderDataAccess : IOrderDataAccess
    {
        private HotelDbConnection db = new HotelDbConnection();

        /// <summary>
        /// GetListOrderFromIdentitycard
        /// </summary>
        /// <returns>GetRoomList</returns>
        public void SetBookingRoom(SetBookingRoomParameter param)
        {
            db.SET_BOOKING_ROOM(param.soPhong, param.ngayVao, param.ngayRa, param.tenKhachHang, param.cMND, param.idNV, param.tinhtrang);
        }

        /// <summary>
        /// GetListOrderFromIdentitycard
        /// </summary>
        /// <returns>GetRoomList</returns>
        public void UpdateBookingRoom(UpdateBookingRoomParameter param)
        {
            db.UPDATE_BOOKING_ROOM(param.iD, param.soPhong, param.ngayVao, param.ngayRa, param.tenKhachHang, param.cMND, param.idNV, param.tinhtrang);
        }

        public IEnumerable<GET_LIST_BOOKROOM_Result> GetListBookRoomAll()
        {
            return db.GET_LIST_BOOKROOM();
        }

        public IEnumerable<FIND_BOOK_ROOM_Result> FindBookRoom(FindBookRoomParameter param)
        {
            return db.FIND_BOOK_ROOM(param.CMND);
        }

        public void DeleteBookRoom(DeleteBookRoomParameter param)
        {
            db.DELETE_BOOK_ROOM(param.ID);
        }
    }
}