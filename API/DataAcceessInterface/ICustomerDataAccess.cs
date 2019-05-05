using DataAcceessInterface.Parameter;
using EntityData;
using System.Collections.Generic;

namespace DataAcceessInterface
{
    public interface ICustomerDataAccess
    {
        IEnumerable<GET_LIST_CUSTOMERS_Result> GetListCustomers();

        void AddCustomer(AddCustomerParameter param);

        void UpdateCustomer(UpdateCustomerParameter param);

        void DeleteCustomery(DeleteCustomerPrameter param);
    }
}