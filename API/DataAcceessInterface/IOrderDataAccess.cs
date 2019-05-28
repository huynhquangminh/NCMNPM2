using DataAcceessInterface.Parameter;

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
    }
}