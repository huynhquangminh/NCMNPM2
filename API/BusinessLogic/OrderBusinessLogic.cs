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
                cfg.CreateMap<GET_LIST_BOOKROOM_Result, GetListBookRoomDto>();
                cfg.CreateMap<FIND_BOOK_ROOM_Result, GetListBookRoomDto>();
            });
            mapper = configMap.CreateMapper();
        }

       
        /// <summary>
        /// SetBookingRoom
        /// </summary>
        /// <returns>bool</returns>
        public async Task<bool> SetBookingRoom(SetBookingRoomRequest request)
        {
            bool result = false;
            try
            {
                var param = new SetBookingRoomParameter()
                {
                    soPhong = request.soPhong,
                    ngayVao = request.ngayVao,
                    ngayRa = request.ngayRa,
                    tenKhachHang = request.tenKhachHang,
                    cMND = request.cMND,
                    idNV = request.idNV
                };
                _dataAccess.SetBookingRoom(param);
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
        /// UpdateBookingRoom
        /// </summary>
        /// <returns>bool</returns>
        public async Task<bool> UpdateBookingRoom(UpdateBookingRoomRequest request)
        {
            bool result = false;
            try
            {
                var param = new UpdateBookingRoomParameter()
                {
                    soPhong = request.soPhong,
                    ngayVao = request.ngayVao,
                    ngayRa = request.ngayRa,
                    tenKhachHang = request.tenKhachHang,
                    cMND = request.cMND,
                    idNV = request.idNV
                };
                _dataAccess.UpdateBookingRoom(param);
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
        /// GetBookRoomAll
        /// </summary>
        /// <returns>GetListBookRoomResponse</returns>
        public async Task<GetListBookRoomResponse> GetBookRoomAll()
        {
            var response = new GetListBookRoomResponse();

            try
            {
                var result = _dataAccess.GetListBookRoomAll();
                if (result != null)
                {
                    response.ListBookRoomp = MapList<GET_LIST_BOOKROOM_Result, GetListBookRoomDto>(result.ToList());
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
        /// FindBookRoom
        /// </summary>
        /// <param name="request"></param>
        /// <returns>GetListBookRoomResponse</returns>
        public async Task<GetListBookRoomResponse> FindBookRoom(FindBookRoomRequest request)
        {
            var response = new GetListBookRoomResponse();

            try
            {
                var param = new FindBookRoomParameter()
                {
                    CMND = request.CMND
                };
                var result = _dataAccess.FindBookRoom(param);
                if (result != null)
                {
                    response.ListBookRoomp = MapList<FIND_BOOK_ROOM_Result, GetListBookRoomDto>(result.ToList());
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
        /// DeleteBookRoom
        /// </summary>
        /// <param name="request"></param>
        /// <returns>bool</returns>
        public async Task<bool> DeleteBookRoom(DeleteBookRoomRequest request)
        {
            bool result = false;
            try
            {
                var param = new DeleteBookRoomParameter()
                {
                   ID = request.ID
                };
                _dataAccess.DeleteBookRoom(param);
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
    }
}

