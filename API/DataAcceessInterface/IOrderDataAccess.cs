using DataAcceessInterface.Parameter;
using EntityData;
using System.Collections.Generic;

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
        void UpdateBookingRoom(UpdateBookingRoomParameter param);

        IEnumerable<GET_LIST_BOOKROOM_Result> GetListBookRoomAll();

        IEnumerable<FIND_BOOK_ROOM_Result> FindBookRoom(FindBookRoomParameter param);

        void DeleteBookRoom(DeleteBookRoomParameter param);
    }
}