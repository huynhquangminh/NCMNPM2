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
    public class UserDataAccess: IUserDataAccess
    {
        private HotelDbConnection db = new HotelDbConnection();

        /// <summary>
        /// UserLogin
        /// </summary>
        /// <returns>GET_SERVICE_ALL_Result</returns>
        public IEnumerable<USER_LOGIN_Result> UserLogin(UserLoginParameter param)
        {
            return db.USER_LOGIN(param.userName, param.password);
        }

        /// <summary>
        /// UserRegister
        /// </summary>
        /// <returns>GET_SERVICE_ALL_Result</returns>
        public void UserRegister(UserRegisterParameter param)
        {
            db.USER_REGISTER(param.tenNhanVien, param.userName, param.password, param.cMND, param.idLoaiNV, param.sDT, param.address);
        }
    }
}
