using BusinessLogicInterface.Requests;
using System.Threading.Tasks;

namespace BusinessLogicInterface
{
    public interface IMailBusinessLogic
    {
        Task<bool> SendMailCommentCustomer(SendMailCommentCustomerRequest request);
    }
}