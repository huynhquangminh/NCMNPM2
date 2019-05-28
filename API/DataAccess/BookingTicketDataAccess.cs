using DataAcceessInterface;
using DataAcceessInterface.Parameter;
using EntityData;
using System.Collections.Generic;

namespace DataAccess
{
    public class BookingTicketDataAccess : IBookingTicketDataAccess
    {
        private HotelDbConnection db = new HotelDbConnection();

        public IEnumerable<GET_LIST_BOOKING_TICKET_Result> GetListTicketBooking()
        {
            return db.GET_LIST_BOOKING_TICKET();
        }

        /// <summary>
        /// GetListOrderFromIdentitycard
        /// </summary>
        /// <returns>GetRoomList</returns>
        public IEnumerable<GET_LIST_ORDER_FROM_IDENTITYCARD_Result> GetListOrderFromIdentitycard(GetListOrderFromIdentitycardParameter request)
        {
            return db.GET_LIST_ORDER_FROM_IDENTITYCARD(request.CMND);
        }

        /// <summary>
        /// InsertBookingTicket
        /// </summary>
        /// <param name="param"></param>
        public void InsertBookingTicket(InsertBookingTicketParameter param)
        {
            db.INSERT_BOOKING_STICKET(param.SoPhong, param.NgayVao, param.NgayRa, param.TinhTrang, param.idKhachHang);
        }

        /// <summary>
        /// UpdateBookingTicket
        /// </summary>
        /// <param name="param"></param>
        public void UpdateBookingTicket(UpdateBookingTicketParameter param)
        {
            db.UPDATE_STATUS_BOOKING_STICKET(param.ID, param.TinhTrang);
        }

        /// <summary>
        /// DeleteBookingTicket
        /// </summary>
        /// <param name="param"></param>
        public void DeleteBookingTicket(DeleteBookingTicketParameter param)
        {
            db.DELETE_BOOKING_TICKET(param.ID);
        }
    }
}