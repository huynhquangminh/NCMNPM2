using DataAcceessInterface;
using DataAcceessInterface.Parameter;
using EntityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
             db.SET_BOOKING_ROOM(param.soPhong,param.ngayVao,param.ngayRa,param.tenKhachHang,param.cMND,param.idNV, param.tinhtrang);
        }

        /// <summary>
        /// GetListOrderFromIdentitycard
        /// </summary>
        /// <returns>GetRoomList</returns>
        public void UpdateBookingRoom(UpdateBookingRoomParameter param)
        {
             db.UPDATE_BOOKING_ROOM(param.iD,param.soPhong,param.ngayVao,param.ngayRa,param.tenKhachHang,param.cMND,param.idNV, param.tinhtrang);
        }

    }
}
