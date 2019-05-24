using AutoMapper;
using BaseApplication;
using BusinessLogicInterface;
using BusinessLogicInterface.Dtos;
using DataAcceessInterface;
using EntityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
using DataAcceessInterface.Parameter;

namespace BusinessLogic
{
    public class OrderBusinessLogic: BaseBusinessLogic, IOrderBusinessLogic
    {
        private readonly IOrderDataAccess _dataAccess;

        public OrderBusinessLogic(IOrderDataAccess dataAccess)
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
                cfg.CreateMap<GET_LIST_ORDER_FROM_IDENTITYCARD_Result, GetListOrderFromIdentitycardDTO>();
            });
            mapper = configMap.CreateMapper();
        }

        /// <summary>
        /// GetListOrderFromIdentitycard
        /// </summary>
        /// <returns>GetListOrderFromIdentitycardResponse</returns>
        public async Task<GetListOrderFromIdentitycardResponse> GetListOrderFromIdentitycard(GetListOrderFromIdentitycardRequest request)
        {
            var response = new GetListOrderFromIdentitycardResponse();

            try
            {
                var param = new GetListOrderFromIdentitycardParameter()
                {
                    cMND=request.cMND
                };
                var result = _dataAccess.GetListOrderFromIdentitycard(param);
                if (result != null)
                {
                    response.ListRoom = MapList<GET_LIST_ORDER_FROM_IDENTITYCARD_Result, GetListOrderFromIdentitycardDTO>(result.ToList());
                    response.Success = true;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
            }
            return await Task.FromResult(response);
        }
    }
}
