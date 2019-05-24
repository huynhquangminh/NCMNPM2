using DataAcceessInterface;
using DataAcceessInterface.Parameter;
using EntityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDataAccess : IOrderDataAccess
    {
        private HotelDbConnection db = new HotelDbConnection();

        /// <summary>
        /// GetListOrderFromIdentitycard
        /// </summary>
        /// <returns>GetRoomList</returns>
        public IEnumerable<GET_LIST_ORDER_FROM_IDENTITYCARD_Result> GetListOrderFromIdentitycard(GetListOrderFromIdentitycardParameter request)
        {
            return db.GET_LIST_ORDER_FROM_IDENTITYCARD(request.cMND);
        }

    }
}
