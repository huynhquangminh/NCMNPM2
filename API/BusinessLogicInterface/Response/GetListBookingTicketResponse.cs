using BaseApplication;
using BusinessLogicInterface.Dtos;
using System.Collections.Generic;

namespace BusinessLogicInterface.Response
{
    public class GetListBookingTicketResponse : BaseResponse
    {
        public List<GetListBookingTicketDTO> ListBookingTicket { get; set; }
    }
}