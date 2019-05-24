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

        /// <summary>
        /// AddListRoom
        /// </summary>
        /// <returns>bool</returns>
        public async Task<bool> AddListRoom(AddListRoomRequest request)
        {
            bool result = false;
            try
            {
                var param = new AddListRoomParameter()
                {
                    tenLoaiPhong = request.tenLoaiPhong,
                    giaPhong = request.giaPhong,
                    imgLoaiPhong=request.imgLoaiPhong
                };
                _dataAccess.AddListRoom(param);
                result = true;
                return result;
            }
            catch (Exception ex)
            {
                result = false;
                return result;
            }
            return await Task.FromResult(result);
        }

        /// <summary>
        /// GetInfoFromRoomNo
        /// </summary>
        /// <returns>bool</returns>
        public async Task<GetInfoFromRoomNoResponse> GetInfoFromRoomNo(GetInfoFromRoomNoRequest request)
        {
            var response = new GetInfoFromRoomNoResponse();
            try
            {
                var param = new GetInfoFromRoomNoParameter()
                {
                    roomNo = request.roomNo
                };
                var result =_dataAccess.GetInfoFromRoomNo(param);
                if (result != null)
                {
                    response.Success = true;
                    response.RoomInfo= MapList<GET_INFO_FROM_ROOM_NO_Result, GetInfoFromRoomNoDTO>(result.ToList());
                }

            }
            catch (Exception ex)
            {
                response.Success=false;
            }
            return await Task.FromResult(response);
        }
    }
}