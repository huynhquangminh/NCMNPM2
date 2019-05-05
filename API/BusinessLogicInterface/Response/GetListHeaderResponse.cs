using BaseApplication;
using BusinessLogicInterface.Dtos;
using System.Collections.Generic;

namespace BusinessLogicInterface.Response
{
    public class GetListHeaderResponse : BaseResponse
    {
        public List<GetListHeaderDto> GetListSlider { get; set; }
        public List<GetListHeaderDto> GetListBanner { get; set; }
    }
}