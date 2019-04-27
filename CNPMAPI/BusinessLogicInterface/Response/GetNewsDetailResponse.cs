using BaseApplication;
using BusinessLogicInterface.Dtos;

namespace BusinessLogicInterface.Response
{
    public class GetNewsDetailResponse : BaseResponse
    {
        public GetNewsDetailDto NewsDetail { get; set; }
    }
}