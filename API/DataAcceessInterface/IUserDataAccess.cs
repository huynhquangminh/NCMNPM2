using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcceessInterface.Parameter;
using EntityData;

namespace DataAcceessInterface
{
    public interface IUserDataAccess
    {
        /// <summary>
        /// UserLogin
        /// </summary>
        /// <returns>USER_LOGIN_Result</returns>
        IEnumerable<USER_LOGIN_Result> UserLogin(UserLoginParameter param);

        /// <summary>
        /// RegisterLogin
        /// </summary>
        /// <returns>void</returns>
        void UserRegister(UserRegisterParameter param);
    }
}
