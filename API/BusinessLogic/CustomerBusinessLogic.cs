using AutoMapper;
using BaseApplication;
using BusinessLogicInterface;
using BusinessLogicInterface.Dtos;
using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
using DataAcceessInterface;
using DataAcceessInterface.Parameter;
using EntityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CustomerBusinessLogic : BaseBusinessLogic, ICustomerBusinessLogic
    {
        private readonly ICustomerDataAccess _dataAccess;

        public CustomerBusinessLogic(ICustomerDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
            ConfigAutoMapper();
        }

        /// <summary>
        /// ConfigAutoMapper
        /// </summary>
        public override void ConfigAutoMapper()
        {
            configMap = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<GET_LIST_CUSTOMERS_Result, ListCustomersDto>();
            });
            mapper = configMap.CreateMapper();
        }

        /// <summary>
        /// GetListCustomers
        /// </summary>
        /// <returns>GetListCustomerResponse</returns>
      public async  Task<GetListCustomerResponse> GetListCustomers()
        {
            var response = new GetListCustomerResponse();
            try
            {
                var result = _dataAccess.GetListCustomers();
                if (result != null)
                {
                    response.ListCustomers = MapList<GET_LIST_CUSTOMERS_Result, ListCustomersDto>(result.ToList());
                    response.Success = true;
                }

            }
            catch (Exception)
            {
                response.Success = false;
            }
            return await Task.FromResult(response);
        }

        /// <summary>
        /// AddCustomer
        /// </summary>
        /// <param name="request">InsertCustomerRequest</param>
        /// <returns>bool</returns>
       public async Task<bool> AddCustomer(InsertCustomerRequest request)
        {
            bool result = false;
            try
            {
                var param = new AddCustomerParameter()
                {
                    Telephone = request.Telephone,
                    UserName = request.UserName,
                    PassWord = request.PassWord,
                    NameCustomer = request.NameCustomer,
                    RoleId = request.RoleId
                };
                _dataAccess.AddCustomer(param);
                result = true;
                return await Task.FromResult(result);

            }
            catch (Exception)
            {
                return await Task.FromResult(result);
            }
        }

        /// <summary>
        /// UpdateCustomer
        /// </summary>
        /// <param name="request">UpdateCustomerRequest</param>
        /// <returns>bool</returns>
        public async Task<bool> UpdateCustomer(UpdateCustomerRequest request)
        {
            bool result = false;
            try
            {
                var param = new UpdateCustomerParameter()
                {
                    ID= request.ID,
                    Telephone = request.Telephone,
                    UserName = request.UserName,
                    PassWord = request.PassWord,
                    NameCustomer = request.NameCustomer,
                    RoleId = request.RoleId
                };
                _dataAccess.UpdateCustomer(param);
                result = true;
                return await Task.FromResult(result);

            }
            catch (Exception)
            {
                return await Task.FromResult(result);
            }
        }

        /// <summary>
        /// DeleteCustomer
        /// </summary>
        /// <param name="request">DeleteCustomerRequest</param>
        /// <returns>bool</returns>
        public async Task<bool> DeleteCustomer(DeleteCustomerRequest request)
        {
            bool result = false;
            try
            {
                var param = new DeleteCustomerPrameter()
                {
                    ID = request.ID,
                    
                };
                _dataAccess.DeleteCustomery(param);
                result = true;
                return await Task.FromResult(result);

            }
            catch (Exception)
            {
                return await Task.FromResult(result);
            }
        }
    }
}
