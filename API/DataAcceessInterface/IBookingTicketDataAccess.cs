using DataAcceessInterface.Parameter;
using EntityData;
using System.Collections.Generic;

namespace DataAcceessInterface
{
    public interface IBookingTicketDataAccess
    {
        IEnumerable<GET_LIST_BOOKING_TICKET_Result> GetListTicketBooking();

        /// <summary>
        /// GetListOrderFromIdentitycard
        /// </summary>
        /// <returns>GET_LIST_ORDER_FROM_IDENTITYCARD_Result</returns>
        IEnumerable<GET_LIST_ORDER_FROM_IDENTITYCARD_Result> GetListOrderFromIdentitycard(GetListOrderFromIdentitycardParameter request);
    }
}