using DataAcceessInterface;
using DataAcceessInterface.Parameter;
using EntityData;
using System.Collections.Generic;

namespace DataAccess
{
    public class ServiceDataAccess : IServiceDataAccess
    {
        private HotelDbConnection db = new HotelDbConnection();

        /// <summary>
        /// GetServiceAll
        /// </summary>
        /// <returns>GET_SERVICE_ALL_Result</returns>
        public IEnumerable<GET_SERVICE_ALL2_Result> GetServiceAll()
        {
            return db.GET_SERVICE_ALL2();
        }

        /// <summary>
        /// AddListService
        /// </summary>
        /// <returns>bool</returns>
        public void AddListService(AddListServiceParameter param)
        {
            db.ADD_LIST_SERVICE(param.tenDichVu, param.donViTinh, param.gia, param.imgDichVu);
        }

        /// <summary>
        /// AddListService
        /// </summary>
        /// <returns>bool</returns>
        public void DeleteItemService(DeleteItemServiceParameter param)
        {
            db.DELETE_ITEM_SERVICE(param.id);
        }

        /// <summary>
        /// UpdateItemService
        /// </summary>
        /// <returns>bool</returns>
        public void UpdateItemService(UpdateItemServiceParameter param)
        {
            db.UPDATE_ITEM_SERVICE(param.id, param.tenDichVu, param.donViTinh, param.gia, param.imgDichVu);
        }
    }
}