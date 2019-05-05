using DataAcceessInterface;
using DataAcceessInterface.Parameter;
using EntityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CustomerDataAccess : ICustomerDataAccess
    {
        private ConnectionStringDBShop db = new ConnectionStringDBShop();

        /// <summary>
        /// GetListCategory
        /// </summary>
        /// <returns>IEnumerable<GET_LIST_CUSTOMERS_Result></returns>
        public IEnumerable<GET_LIST_CUSTOMERS_Result> GetListCustomers()
        {
            return db.GET_LIST_CUSTOMERS();
        }

        /// <summary>
        /// AddCustomer
        /// </summary>
        /// <param name="param">AddCustomerParameter</param>
        public void AddCustomer(AddCustomerParameter param)
        {
            db.INSERT_CUSTOMER(param.Telephone, param.UserName, param.PassWord, param.NameCustomer, param.RoleId);
        }

        /// <summary>
        /// UpdateCustomer
        /// </summary>
        /// <param name="param">UpdateCustomerParameter</param>
        public void UpdateCustomer(UpdateCustomerParameter param)
        {
            db.UPDATE_CUSTOMER(param.ID, param.Telephone, param.UserName, param.PassWord, param.NameCustomer, param.RoleId);
        }


        /// <summary>
        /// DeleteCustomery
        /// </summary>
        /// <param name="param">DeleteCustomerPrameter</param>
        public void DeleteCustomery(DeleteCustomerPrameter param)
        {
            db.DELETE_CUSTOMER(param.ID);
        }
    }
}
