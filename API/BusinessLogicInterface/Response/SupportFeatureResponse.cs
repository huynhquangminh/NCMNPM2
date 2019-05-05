using BaseApplication;
using BusinessLogicInterface.Dtos;

namespace BusinessLogicInterface.Response
{
    public class SupportFeatureResponse : BaseResponse
    {
        public SupportFeatureDto infoWebSite { get; set; }
    }
}