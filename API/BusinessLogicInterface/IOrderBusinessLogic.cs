﻿using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicInterface
{
    public interface IOrderBusinessLogic
    {
        /// <summary>
        /// GetListOrderFromIdentitycard
        /// </summary>
        /// <returns>GetListOrderFromIdentitycard</returns>
        Task<GetListOrderFromIdentitycardResponse> GetListOrderFromIdentitycard(GetListOrderFromIdentitycardRequest request);
    }
}