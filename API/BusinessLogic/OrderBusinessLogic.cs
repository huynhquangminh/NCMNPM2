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
        /// SetBookingRoom
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
    }
}
