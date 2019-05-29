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
            catch (Exception ex)
            {
                response.Success = false;
            }
            return await Task.FromResult(response);
        }

        /// <summary>
        /// AddListService
        /// </summary>
        /// <returns>bool</returns>
        public async Task<bool> AddListService(AddListServiceRequest request)
        {
            bool result = false;
            try
            {
                var param = new AddListServiceParameter(){
                    tenDichVu = request.tenDichVu,
                    donViTinh = request.donViTinh,
                    gia = request.gia,
                    imgDichVu = request.imgDichVu
                };
                _dataAccess.AddListService(param);
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
        /// DeleteItemService
        /// </summary>
        /// <returns>bool</returns>
        public async Task<bool> DeleteItemService(DeleteItemServiceRequest request)
        {
            bool result = false;
            try
            {
                var param = new DeleteItemServiceParameter()
                {
                    id = request.id
                };
                _dataAccess.DeleteItemService(param);
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
        /// UpdateItemService
        /// </summary>
        /// <returns>bool</returns>
        public async Task<bool> UpdateItemService(UpdateItemServiceRequest request)
        {
            bool result = false;
            try
            {
                var param = new UpdateItemServiceParameter()
                {
                    id = request.id,
                    tenDichVu = request.tenDichVu,
                    donViTinh = request.donViTinh,
                    gia = request.gia,
                    imgDichVu = request.imgDichVu
                };
                _dataAccess.UpdateItemService(param);
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
        /// GetListServiceTicket
        /// </summary>
        /// <returns>GetListServiceTicketResponse</returns>
        public async Task<GetListServiceTicketResponse> GetListServiceTicket()
        {
            var response = new GetListServiceTicketResponse();
            try
            {
                var result = _dataAccess.GetListServiceTicket();
                if (result != null)
                {
                    response.List = MapList<GET_LIST_SERVICE_TICKET_Result, GetListServiceTicketDTO>(result.ToList());
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
        /// FindServiceTicket
        /// </summary>
        /// <returns>FindServiceTicketResponse</returns>
        public async Task<FindServiceTicketResponse> FindServiceTicket(FindServiceTicketRequest request)
        {
            var response = new FindServiceTicketResponse();
            try
            {
                var param = new FindServiceTicketParameter()
                {
                    SoPhong=request.SoPhong
                };
                var result = _dataAccess.FindServiceTicket(param);
                if (result != null)
                {
                    response.ServiceInfo = MapList<FIND_SERVICE_TICKET_Result, FindServiceTicketDTO>(result.ToList());
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
        /// UpdateServiceSticket
        /// </summary>
        /// <returns>bool</returns>
        public async Task<bool> UpdateServiceSticket(UpdateServiceSticketRequest request)
        {
            bool result = false;
            try
            {
                var param = new UpdateServiceSticketParameter()
                {
                    ID=request.ID,
                    idDatPhong=request.idDatPhong,
                    NgayDat=request.NgayDat,
                    idDichVu=request.idDichVu,
                    SoLuong=request.SoLuong,
                    Gia=request.Gia,
                    TinhTrang=request.TinhTrang,
                    idNV=request.idNV
                };
                _dataAccess.UpdateServiceSticket(param);
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
        /// DeleteItemService
        /// </summary>
        /// <returns>bool</returns>
        public async Task<bool> DeleteServiceSticket(DeleteServiceSticketRequest request)
        {
            bool result = false;
            try
            {
                var param = new DeleteServiceSticketParameter()
                {
                    ID=request.ID
                };
                _dataAccess.DeleteServiceSticket(param);
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