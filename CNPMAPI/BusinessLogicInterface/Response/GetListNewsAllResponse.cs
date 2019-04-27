using BaseApplication;
using BusinessLogicInterface.Dtos;
using System.Collections.Generic;

namespace BusinessLogicInterface.Response
{
    public class GetListNewsAllResponse : BaseResponse
    {
        public List<GetListNewsDto> listNewsByDate { get; set; }
        public List<GetListNewsDto> listNewsByView { get; set; }
    }
}