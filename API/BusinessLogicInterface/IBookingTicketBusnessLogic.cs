using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
using System.Threading.Tasks;

namespace BusinessLogicInterface
{
    public interface IBookingTicketBusnessLogic
    {
        Task<GetListBookingTicketResponse> GetListBookingTicket();

        Task<GetListOrderFromIdentitycardResponse> GetListOrderFromIdentitycard(GetListOrderFromIdentitycardRequest request);

        Task<bool> InsertBookingTicket(InsertBookingTicketRequest request);

        Task<bool> UpdateStatusBookingTicket(UpdateBookingTicketRequest request);

        Task<bool> DeleteStatusBookingTicket(DeleteBookingTicketRequest request);
    }
}