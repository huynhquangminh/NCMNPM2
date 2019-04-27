using BaseApplication;
using BusinessLogicInterface.Dtos;

namespace BusinessLogicInterface.Response
{
    public class GetIntroductionResponse : BaseResponse
    {
        public GetIntroductionDto Introduction { get; set; }
    }
}