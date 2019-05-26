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

    }
}
