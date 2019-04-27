using BaseApplication;
using BusinessLogicInterface.Dtos;

namespace BusinessLogicInterface.Response
{
    public class GetProductDetailResponse : BaseResponse
    {
        public ProductDetailDto ProductDetail { get; set; }
    }
}