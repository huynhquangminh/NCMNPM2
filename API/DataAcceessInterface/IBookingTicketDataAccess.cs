using DataAcceessInterface.Parameter;
using EntityData;
using System.Collections.Generic;

namespace DataAcceessInterface
{
    public interface IBookingTicketDataAccess
    {
        IEnumerable<GET_LIST_BOOKING_TICKET_Result> GetListTicketBooking();

        IEnumerable<GET_LIST_ORDER_FROM_IDENTITYCARD_Result> GetListOrderFromIdentitycard(GetListOrderFromIdentitycardParameter request);

        void InsertBookingTicket(InsertBookingTicketParameter param);

        void UpdateBookingTicket(UpdateBookingTicketParameter param);

        void DeleteBookingTicket(DeleteBookingTicketParameter param);
    }
}