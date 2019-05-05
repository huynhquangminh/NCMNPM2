using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
using System.Threading.Tasks;

namespace BusinessLogicInterface
{
    public interface INewsBusinessLogic
    {
        Task<GetNewsAllResponse> GetNewsAll();
        Task<GetListNewsAllResponse> GetListNewsAll();
        Task<GetNewsDetailResponse> GetNewsDetail(GetNewsDetailRequest request);
        Task<bool> Add_News(AddNewsRequest request);
        Task<bool> Edit_News(EditNewsRequest request);
        Task<bool> Delete_News(DeleteNewsRequest request);
    }
}