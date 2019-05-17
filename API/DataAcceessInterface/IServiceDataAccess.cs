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
      
    }

}