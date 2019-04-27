using BaseApplication;
using BusinessLogicInterface.Dtos;
using System.Collections.Generic;

namespace BusinessLogicInterface.Response
{
    public class GetProductIndexResponse : BaseResponse
    {
        public List<GetProductIndex> ListProductNew { get; set; }
        public List<GetProductIndex> ListProductSellMax { get; set; }
        public List<GetProductIndex> ListProductInterest { get; set; }
        public List<GetProductIndex> ListProductPriceSale{ get; set; }
    }
}