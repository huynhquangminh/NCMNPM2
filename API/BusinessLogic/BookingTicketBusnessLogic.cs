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
   public class BookingTicketBusnessLogic : BaseBusinessLogic,IBookingTicketBusnessLogic
    {
        private readonly IBookingTicketDataAccess _dataAccess;

        public BookingTicketBusnessLogic(IBookingTicketDataAccess dataAccess)
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
                cfg.CreateMap<GET_LIST_BOOKING_TICKET_Result, GetListBookingTicketDTO>();
                cfg.CreateMap<GET_LIST_ORDER_FROM_IDENTITYCARD_Result, GetListOrderFromIdentitycardDTO>();
            });
            mapper = configMap.CreateMapper();
        }

        public async Task<GetListBookingTicketResponse> GetListBookingTicket()
        {
            var response = new GetListBookingTicketResponse();

            try
            {
                var result = _dataAccess.GetListTicketBooking();
                if (result != null)
                {
                    response.ListBookingTicket = MapList<GET_LIST_BOOKING_TICKET_Result, GetListBookingTicketDTO>(result.ToList());
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
                    CMND = request.CMND
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
