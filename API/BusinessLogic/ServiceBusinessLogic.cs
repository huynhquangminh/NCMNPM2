using AutoMapper;
using BaseApplication;
using BusinessLogicInterface;
using BusinessLogicInterface.Dtos;
using BusinessLogicInterface.Response;
using DataAcceessInterface;
using EntityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ServiceBusinessLogic : BaseBusinessLogic, IServiceBusinessLogic
    {
        private readonly IServiceDataAccess _dataAccess;

        public ServiceBusinessLogic(IServiceDataAccess dataAccess)
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
                cfg.CreateMap<GET_SERVICE_ALL_Result, GetServiceDTO>();
            });
            mapper = configMap.CreateMapper();
        }

        /// <summary>
        /// GetServiceAll
        /// </summary>
        /// <returns>GetServiceResponse</returns>
        public async Task<GetServiceResponse> GetServiceAll()
        {
            var response = new GetServiceResponse();
            try
            {
                var result = _dataAccess.GetServiceAll();
                if (result != null)
                {
                    response.ListServiceAll = MapList<GET_SERVICE_ALL_Result, GetServiceDTO>(result.ToList());
                    response.Success = true;
                }

            }
            catch (Exception  ex)
            {
                response.Success = false;
            }
            return await Task.FromResult(response);
        }
        /// <summary>
        /// GetServiceAll
        /// </summary>
        /// <returns>GetServiceResponse</returns>
        public async Task<GetListRoomResponse> GetRoomList()
        {
            var response = new GetListRoomResponse();
            try
            {
                var result = _dataAccess.GetRoomList();
                if (result != null)
                {
                    response.ListRoom = MapList<GET_LIST_ROOM_Result, GetListRoomDTO>(result.ToList());
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
