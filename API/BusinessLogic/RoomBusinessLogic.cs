using AutoMapper;
using BaseApplication;
using BusinessLogicInterface;
using BusinessLogicInterface.Dtos;
using BusinessLogicInterface.Response;
using DataAcceessInterface;
using EntityData;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class RoomBusinessLogic : BaseBusinessLogic, IRoomBusinessLogic
    {
        private readonly IRoomDataAccess _dataAccess;

        public RoomBusinessLogic(IRoomDataAccess dataAccess)
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
                cfg.CreateMap<GET_LIST_ROOM_Result, GetListRoomDTO>();
            });
            mapper = configMap.CreateMapper();
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