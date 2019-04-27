using AutoMapper;
using BaseApplication;
using BusinessLogicInterface;
using BusinessLogicInterface.Dtos;
using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
using DataAcceessInterface;
using DataAcceessInterface.Parameter;
using EntityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
   public class CategoryBusinessLogic : BaseBusinessLogic,  ICategoryBusinessLogic
    {
        private readonly ICategoryDataAccess _dataAccess;

        public CategoryBusinessLogic(ICategoryDataAccess dataAccess)
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
                cfg.CreateMap<GETLISTCATEGORY_Result, GetCategoryDto>();
            });
            mapper = configMap.CreateMapper();
        }

        /// <summary>
        /// GetListCategory
        /// </summary>
        /// <returns>GetCategoryResponse</returns>
        public async Task<GetCategoryResponse> GetListCategory()
        {
            var response = new GetCategoryResponse();
            try
            {
                var result = _dataAccess.GetListCategory();
                if (result != null)
                {
                    response.ListGetCategory = MapList<GETLISTCATEGORY_Result, GetCategoryDto>(result.ToList());
                    response.Success = true;
                }

            }
            catch (Exception )
            {
                response.Success = false;
            }
            return await Task.FromResult(response);
        }

        /// <summary>
        /// AddCategory
        /// </summary>
        /// <param name="request">AddCategoryRequest</param>
        /// <returns>bool</returns>
        public async Task<bool> AddCategory(AddCategoryRequest request)
        {
            bool result = false; 
            try
            {
                var param = new AddCategoryParameter()
                {
                    nameCategory = request.nameCategory,
                    imgCategory = request.imgCategory
                };
                _dataAccess.AddCategory(param);
                result = true;
                return result;

            }
            catch (Exception )
            {
                result = false;
                
            }
            return await Task.FromResult(result);
        }

        /// <summary>
        /// EditCategory
        /// </summary>
        /// <param name="request">EditCategoryRequest</param>
        /// <returns>bool</returns>
        public async Task<bool> EditCategory(EditCategoryRequest request)
        {
            bool result = false;
            try
            {
                var param = new UpdateCategoryParameter()
                {
                    id = request.id,
                    nameCategory = request.nameCategory,
                    imgCategory = request.imgCategory
                };
                _dataAccess.EditCategory(param);
                result = true;
                return result;

            }
            catch (Exception )
            {
                result = false;
               
            }
            return await Task.FromResult(result);
        }

        /// <summary>
        /// DeleteCategory
        /// </summary>
        /// <param name="request">DeleteCategoryRequest</param>
        /// <returns>bool</returns>
        public async Task<bool> DeleteCategory(DeleteCategoryRequest request)
        {
            bool result = false;
            try
            {
                var param = new DeleteCategoryParameter()
                {
                    id = request.id
                };
                _dataAccess.DeleteCategory(param);
                result = true;
                return await Task.FromResult(result);

            }
            catch (Exception )
            {
                result = false;
                return await Task.FromResult(result);
            }
            
        }
    }
}
