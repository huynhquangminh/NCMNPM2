﻿using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicInterface
{
   public interface IServiceBusinessLogic
    {
        /// <summary>
        /// GetServiceAll
        /// </summary>
        /// <returns>GetServiceResponse</returns>
        Task<GetServiceResponse> GetServiceAll();

        /// <summary>
        /// AddListService
        /// </summary>
        /// <returns>bool</returns>
        Task<bool> AddListService(AddListServiceRequest request);

        /// <summary>
        /// DeleteItemService
        /// </summary>
        /// <returns>bool</returns>
        Task<bool> DeleteItemService(DeleteItemServiceRequest request);

        /// <summary>
        /// UpdateItemService
        /// </summary>
        /// <returns>bool</returns>
        Task<bool> UpdateItemService(UpdateItemServiceRequest request);

    }
}
