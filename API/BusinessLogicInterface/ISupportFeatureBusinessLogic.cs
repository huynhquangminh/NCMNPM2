using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
using System.Threading.Tasks;

namespace BusinessLogicInterface
{
    public interface ISupportFeatureBusinessLogic
    {
        Task<SupportFeatureResponse> GetInfoWebSite();
        Task<bool> SendMailCommentCustomer(SendMailCommentCustomerRequest request);
    }
}