using BaseApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicInterface.Requests
{
    public class UserLoginRequest:BaseResponse
    {
        public string userName { get; set; }
        public string password { get; set; }
    }
}
