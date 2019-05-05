using BusinessLogicInterface.Response;
using System.Threading.Tasks;

namespace BusinessLogicInterface
{
    public interface IHeaderBusinessLogic
    {
        Task<GetListHeaderResponse> GetListHeader();
    }
}