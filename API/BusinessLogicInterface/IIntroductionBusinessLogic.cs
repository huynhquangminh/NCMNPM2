using BusinessLogicInterface.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicInterface
{
   public interface IIntroductionBusinessLogic
    {
        Task<GetIntroductionResponse> GetIntroduction();
    }
}
