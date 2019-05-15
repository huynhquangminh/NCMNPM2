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
        /// GetRoomList
        /// </summary>
        /// <returns>GET_SERVICE_ALL_Result</returns>
        IEnumerable<GET_LIST_ROOM_Result> GetRoomList();

        /// <summary>
        /// GetServiceList
        /// </summary>
        /// <returns>GET_SERVICE_LIST_Result</returns>
        IEnumerable<GET_LIST_SERVICE_Result> GetServiceList();
    }
}