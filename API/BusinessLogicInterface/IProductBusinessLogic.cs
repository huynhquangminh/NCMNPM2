using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
using System.Threading.Tasks;

namespace BusinessLogicInterface
{
    public interface IProductBusinessLogic
    {
        Task<GetProductIndexResponse> GetListProductIndex();

        Task<GetProductDetailResponse> GetProductDetailByID(ProductDetailRequest request);

        Task<GetProductAllResponse> GetProductByCategory(GetProductByCategoryRequest request);

        Task<GetProductAllResponse> GetProductAll(GetProductAllRequest request);

        Task<FindProductResponse> FindProductByKey(FindProductRequest request);

        Task<GetListProductAdminResponse> GetListProductAdmin(GetProductAllRequest request);

        Task<bool> InsertProduct(InsertProductRequest request);

        Task<bool> UpdateProduct(UpdateProductRequest request);

        Task<bool> DeleteProduct(DeleteProductRequest request);

    }
}