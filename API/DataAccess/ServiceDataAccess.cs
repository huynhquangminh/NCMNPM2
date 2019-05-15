using DataAcceessInterface;
using EntityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ServiceDataAccess : IServiceDataAccess
    {
        private HotelDbConnection db = new HotelDbConnection();

        /// <summary>
        /// GetServiceAll
        /// </summary>
        /// <returns>GET_SERVICE_ALL_Result</returns>
        public IEnumerable<GET_SERVICE_ALL_Result> GetServiceAll()
        {
            return db.GET_SERVICE_ALL();
        }

        /// <summary>
        /// GetRoomList
        /// </summary>
        /// <returns>GetRoomList</returns>
        public IEnumerable<GET_LIST_ROOM_Result> GetRoomList()
        {
            return db.GET_LIST_ROOM();
        }
    }
}
