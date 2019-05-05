using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicInterface
{
    public interface ICustomerBusinessLogic
    {
        /// <summary>
        /// GetListCustomers
        /// </summary>
        /// <returns>GetListCustomerResponse</returns>
        Task<GetListCustomerResponse> GetListCustomers();

        /// <summary>
        /// AddCustomer
        /// </summary>
        /// <param name="request">InsertCustomerRequest</param>
        /// <returns>bool</returns>
        Task<bool> AddCustomer(InsertCustomerRequest request);

        /// <summary>
        /// UpdateCustomer
        /// </summary>
        /// <param name="request">UpdateCustomerRequest</param>
        /// <returns>bool</returns>
        Task<bool>UpdateCustomer(UpdateCustomerRequest request);

        /// <summary>
        /// DeleteCustomer
        /// </summary>
        /// <param name="request">DeleteCustomerRequest</param>
        /// <returns>bool</returns>
        Task<bool> DeleteCustomer(DeleteCustomerRequest request);
    }
}
