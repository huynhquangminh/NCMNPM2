using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
using System.Threading.Tasks;

namespace BusinessLogicInterface
{
    public interface ICategoryBusinessLogic
    {
        /// <summary>
        /// GetListCategory
        /// </summary>
        /// <returns>GetCategoryResponse</returns>
        Task<GetCategoryResponse> GetListCategory();

        /// <summary>
        /// AddCategory
        /// </summary>
        /// <param name="request">AddCategoryRequest</param>
        /// <returns>bool</returns>
        Task<bool> AddCategory(AddCategoryRequest request);

        /// <summary>
        /// EditCategory
        /// </summary>
        /// <param name="request">EditCategoryRequest</param>
        /// <returns>bool</returns>
        Task<bool> EditCategory(EditCategoryRequest request);

        /// <summary>
        /// DeleteCategory
        /// </summary>
        /// <param name="request">DeleteCategoryRequest</param>
        /// <returns>bool</returns>
        Task<bool> DeleteCategory(DeleteCategoryRequest request);

    }
}