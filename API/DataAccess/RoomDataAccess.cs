﻿using DataAcceessInterface;
using EntityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
   public class RoomDataAccess: IRoomDataAccess
    {
        private HotelDbConnection db = new HotelDbConnection();
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