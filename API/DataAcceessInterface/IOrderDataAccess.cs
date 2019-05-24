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
        /// GetListOrderFromIdentitycard
        /// </summary>
        /// <returns>GET_LIST_ORDER_FROM_IDENTITYCARD_Result</returns>
        IEnumerable<GET_LIST_ORDER_FROM_IDENTITYCARD_Result> GetListOrderFromIdentitycard(GetListOrderFromIdentitycardParameter request);
    }
}
