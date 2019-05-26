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
    }
}