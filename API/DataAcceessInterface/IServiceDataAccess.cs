using DataAcceessInterface.Parameter;
using EntityData;
using System.Collections.Generic;

namespace DataAcceessInterface
{
    public interface IServiceDataAccess
    {
        /// <summary>
        /// GetServiceAll
        /// </summary>
        /// <returns>GET_SERVICE_ALL_Result</returns>
        IEnumerable<GET_SERVICE_ALL_Result> GetServiceAll();

        /// <summary>
        /// AddListService
        /// </summary>
        /// <returns>void</returns>
        void AddListService(AddListServiceParameter param);

        /// <summary>
        /// DeleteItemService
        /// </summary>
        /// <returns>void</returns>
        void DeleteItemService(DeleteItemServiceParameter param);

        /// <summary>
        /// UpdateItemService
        /// </summary>
        /// <returns>void</returns>
        void UpdateItemService(UpdateItemServiceParameter param);

        /// <summary>
        /// UpdateItemService
        /// </summary>
        /// <returns>GET_LIST_SERVICE_TICKET_Result</returns>
        IEnumerable<GET_LIST_SERVICE_TICKET_Result> GetListServiceTicket();

        /// <summary>
        /// FindServiceTicket
        /// </summary>
        /// <returns>FIND_SERVICE_TICKET_Result</returns>
        IEnumerable<FIND_SERVICE_TICKET_Result> FindServiceTicket(FindServiceTicketParameter param);


        /// <summary>
        /// DeleteServiceSticket
        /// </summary>
        /// <returns>void</returns>
        void DeleteServiceSticket(DeleteServiceSticketParameter param);

        /// <summary>
        /// UpdateServiceSticket
        /// </summary>
        /// <returns>void</returns>
        void UpdateServiceSticket(UpdateServiceSticketParameter param);

    }

}