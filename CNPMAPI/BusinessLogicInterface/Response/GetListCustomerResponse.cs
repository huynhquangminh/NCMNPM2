using BaseApplication;
using BusinessLogicInterface.Dtos;
using System.Collections.Generic;

namespace BusinessLogicInterface.Response
{
    public class GetListCustomerResponse : BaseResponse
    {
        public List<ListCustomersDto> ListCustomers { get; set; }
    }
}