using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;

namespace BusinessLogicInterface
{
    public interface IUserBusinessLogic
    {
        /// <summary>
        /// UserLogin
        /// </summary>
        /// <returns>UserLoginResponse</returns>
        Task<UserLoginResponse> UserLogin(UserLoginRequest request);

        /// <summary>
        /// RegisterLogin
        /// </summary>
        /// <returns>bool</returns>
        Task<bool> UserRegister(UserRegisterRequest request);
    }
}
