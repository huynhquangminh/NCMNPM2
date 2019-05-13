using BusinessLogicInterface.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicInterface
{
   public interface IServiceBusinessLogic
    {
        /// <summary>
        /// GetServiceAll
        /// </summary>
        /// <returns>GetServiceResponse</returns>
        Task<GetServiceResponse> GetServiceAll();

        /// <summary>
        /// GetRoomList
        /// </summary>
        /// <returns>GetListRoomResponse</returns>
        Task<GetListRoomResponse> GetRoomList();
    }
}
