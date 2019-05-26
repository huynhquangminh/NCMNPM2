using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcceessInterface.Parameter;
using EntityData;

namespace DataAcceessInterface
{
    public interface IOrderDataAccess
    {
       
        /// <summary>
        /// SetBookingRoom
        /// </summary>
        /// <returns>bool</returns>
        void SetBookingRoom(SetBookingRoomParameter param);

        /// <summary>
        /// UpdateBookingRoom
        /// </summary>
        /// <returns>bool</returns>
         void  UpdateBookingRoom(UpdateBookingRoomParameter param);
    }
}
