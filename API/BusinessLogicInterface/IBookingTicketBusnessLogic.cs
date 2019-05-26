using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
using System.Threading.Tasks;

namespace BusinessLogicInterface
{
    public interface IBookingTicketBusnessLogic
    {
        Task<GetListBookingTicketResponse> GetListBookingTicket();

        /// <summary>
        /// GetListOrderFromIdentitycard
        /// </summary>
        /// <returns>GetListOrderFromIdentitycard</returns>
        Task<GetListOrderFromIdentitycardResponse> GetListOrderFromIdentitycard(GetListOrderFromIdentitycardRequest request);
    }
}