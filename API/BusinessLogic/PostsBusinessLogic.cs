using BaseApplication;
using BusinessLogicInterface;
using DataAcceessInterface;
using System;
using BusinessLogicInterface.Dtos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityData;
using BusinessLogicInterface.Response;
using AutoMapper;

namespace BusinessLogic
{
    public class PostsBusinessLogic : BaseBusinessLogic, IPostsBusinessLogic
    {
        private readonly IPostsDataAcess _dataAccess;

        public PostsBusinessLogic(IPostsDataAcess dataAccess)
        {
            _dataAccess = dataAccess;
            ConfigAutoMapper();
        }

        /// <summary>
        /// ConfigAutoMapper
        /// </summary>
        public override void ConfigAutoMapper()
        {
            configMap = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<GET_LIST_POSTS_Result, GetListPostsDTO>();
            });
            mapper = configMap.CreateMapper();
        }

        /// <summary>
        /// GetServiceAll
        /// </summary>
        /// <returns>GetServiceResponse</returns>
        public async Task<GetPostsResponse> GetPostsList()
        {
            var response = new GetPostsResponse();
            try
            {
                var result = _dataAccess.GetPostsList();
                if (result != null)
                {
                    response.ListPosts = MapList<GET_LIST_POSTS_Result, GetListPostsDTO>(result.ToList());
                    response.Success = true;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
            }
            return await Task.FromResult(response);
        }
    }
}
