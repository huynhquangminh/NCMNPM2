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
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ProductBusinessLogic : BaseBusinessLogic, IProductBusinessLogic
    {
        private readonly IProductDataAccess _dataAccess;
        private readonly ICategoryDataAccess _dataAccessCategory;

        public ProductBusinessLogic(IProductDataAccess dataAccess, ICategoryDataAccess dataAccessCategory)
        {
            _dataAccess = dataAccess;
            _dataAccessCategory = dataAccessCategory;
            ConfigAutoMapper();
        }

        /// <summary>
        /// ConfigAutoMapper
        /// </summary>
        public override void ConfigAutoMapper()
        {
            configMap = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<GETPRODUCT_NEWS_Result, GetProductIndex>();
                cfg.CreateMap<GETLISTPRODUCT_SELLMAX_Result, GetProductIndex>();
                cfg.CreateMap<GETLISTPRODUCT_INTEREST_Result, GetProductIndex>();
                cfg.CreateMap<GETLISTPRODUCT_PRICESALE_Result, GetProductIndex>();
                cfg.CreateMap<GETPRODUCTDETAIL_BY_ID_Result, ProductDetailDto>();
                cfg.CreateMap<GET_PRODUCT_BY_CATEGORY_Result, GetProductAllDto>();

                cfg.CreateMap<GETPRODUCTALL_Result, GetProductAllDto>();
                cfg.CreateMap<GETPRODUCT_BY_TYPE_PRICE_ASC_Result, GetProductAllDto>();
                cfg.CreateMap<GETPRODUCT_BY_TYPE_PRICE_DESC_Result, GetProductAllDto>();
                cfg.CreateMap<GETPRODUCT_BY_TYPE_DATE_ASC_Result, GetProductAllDto>();
                cfg.CreateMap<FIND_PRODUCT_Result, FindProductDto>();
                cfg.CreateMap<GET_LISTPRODUCT_ALL_Result, GetListProductAdminDto>();
                cfg.CreateMap<GETLISTCATEGORY_Result, GetCategoryDto>();
            });
            mapper = configMap.CreateMapper();
        }

        /// <summary>
        /// GetListProductNew
        /// </summary>
        /// <returns>GetProductNewResponse</returns>
        public async Task<GetProductIndexResponse> GetListProductIndex()
        {
            var response = new GetProductIndexResponse();
            try
            {
                var resultProductNew = _dataAccess.GetListProductNew();
                var resultProductSellMax = _dataAccess.GetListProductSellMax();
                var resultProductInterest = _dataAccess.GetListProductInterestProcduct();
                var resultProductPriceSale = _dataAccess.GetListProductPriceSale();
                if (resultProductNew != null)
                {
                    response.ListProductNew = MapList<GETPRODUCT_NEWS_Result, GetProductIndex>(resultProductNew.ToList());
                    response.Success = true;
                }
                if (resultProductSellMax != null)
                {
                    response.ListProductSellMax = MapList<GETLISTPRODUCT_SELLMAX_Result, GetProductIndex>(resultProductSellMax.ToList());
                    response.Success = true;
                }
                if (resultProductInterest != null)
                {
                    response.ListProductInterest = MapList<GETLISTPRODUCT_INTEREST_Result, GetProductIndex>(resultProductInterest.ToList());
                    response.Success = true;
                }
                if (resultProductPriceSale != null)
                {
                    response.ListProductPriceSale = MapList<GETLISTPRODUCT_PRICESALE_Result, GetProductIndex>(resultProductPriceSale.ToList());
                    response.Success = true;
                }

            }
            catch (Exception)
            {
                response.Success = false;
            }
            return await Task.FromResult(response);
        }

        /// <summary>
        /// GetProductDetailByID
        /// </summary>
        /// <param name="request">ProductDetailRequest</param>
        /// <returns>GetProductDetailResponse</returns>
        public async Task<GetProductDetailResponse> GetProductDetailByID(ProductDetailRequest request)
        {
            var response = new GetProductDetailResponse();
            try
            {
                var param = new ProductDetailByIDParameter()
                {
                    ID = request.ID
                };

                var result = _dataAccess.GetProductDetailByID(param);
                if (result != null)
                {
                    response.ProductDetail = mapper.Map<GETPRODUCTDETAIL_BY_ID_Result, ProductDetailDto>(result);
                    response.Success = true;
                }
            }
            catch (Exception)
            {
                response.Success = false;
            }
            return await Task.FromResult(response);
        }

        /// <summary>
        /// GetProductByCategory
        /// </summary>
        /// <param name="request">GetProductByCategoryRequest</param>
        /// <returns>GetProductAllResponse</returns>
        public async Task<GetProductAllResponse> GetProductByCategory(GetProductByCategoryRequest request)
        {
            var response = new GetProductAllResponse();
            try
            {
                var param = new GetProductByCategoryParameter()
                {
                    IDCategory = request.IDCategory,
                    StartPage = request.StartPage
                };

                var result = _dataAccess.GetListProductByCategory(param);
                if (result != null)
                {
                    response.ListProductAll = MapList<GET_PRODUCT_BY_CATEGORY_Result, GetProductAllDto>(result.ToList());
                    response.Success = true;
                }
            }
            catch (Exception)
            {
                response.Success = false;
            }
            return await Task.FromResult(response);
        }

        /// <summary>
        /// FindProductByKey
        /// </summary>
        /// <param name="request">FindProductRequest</param>
        /// <returns>FindProductResponse</returns>
        public async Task<FindProductResponse> FindProductByKey(FindProductRequest request)
        {
            var response = new FindProductResponse();
            try
            {
                var param = new FindProductParameter()
                {
                    key = request.key
                };

                var result = _dataAccess.FindProduct(param);
                if (result != null)
                {
                    response.ListProduct = MapList<FIND_PRODUCT_Result, FindProductDto>(result.ToList());
                    response.Success = true;
                }
            }
            catch (Exception)
            {
                response.Success = false;
            }
            return await Task.FromResult(response);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<GetProductAllResponse> GetProductAll(GetProductAllRequest request)
        {
            var response = new GetProductAllResponse();

            var param = new GetProductAllParameter()
            {
                StartPage = request.StartPage,
            };
            switch (request.Type)
            {
                case 0:
                    response = CheckTypeByDateASC(param);
                    break;
                case 1:
                    response = CheckTypeByPriceASC(param);
                    break;
                case 2:
                    response = CheckTypeByPriceDESC(param);
                    break;
                case 3:
                    response = CheckTypeByDateASC(param);
                    break;
                case 4:
                    response = CheckTypeByDateDESC(param);
                    break;

            }
            return await Task.FromResult(response);
        }

        /// <summary>
        /// GetListProductAdmin
        /// </summary>
        /// <param name="request"></param>
        /// <returns>GetListProductAdminResponse</returns>
        public async Task<GetListProductAdminResponse> GetListProductAdmin(GetProductAllRequest request)
        {
            var response = new GetListProductAdminResponse() {
                ListCategory = new List<GetCategoryDto>
                {
                    new GetCategoryDto()
                },

                ListProductAdmin = new List<GetListProductAdminDto>
                {
                    new GetListProductAdminDto()
                }
            };
            try
            {
                var param = new GetProductAllParameter()
                {
                    StartPage = request.StartPage,
                };
                var result = _dataAccess.GetListProductAdmin(param);
                var resultCategory = _dataAccessCategory.GetListCategory();
                if (result != null && resultCategory != null)
                {
                    response.ListProductAdmin = MapList<GET_LISTPRODUCT_ALL_Result, GetListProductAdminDto>(result.ToList());
                    response.ListCategory = MapList<GETLISTCATEGORY_Result, GetCategoryDto>(resultCategory.ToList());
                    response.Success = true;
                }

                return await Task.FromResult(response);
            }
            catch (Exception)
            {
                response.Success = false;
                return await Task.FromResult(response);
            }
        }

        /// <summary>
        /// InsertProduct
        /// </summary>
        /// <param name="request"></param>
        /// <returns>bool</returns>
        public async Task<bool> InsertProduct(InsertProductRequest request)
        {
            bool result = false;
            try
            {
                var param = new InsertProductParameter()
                {
                    NameProduct = request.NameProduct,
                    Price = request.Price,
                    BriefDes = request.BriefDes,
                    Description = request.Description,
                    ImageProduct = request.ImageProduct,
                    ImageProductDetail1 = request.ImageProductDetail1,
                    ImageProductDetail2 = request.ImageProductDetail2,
                    Amount = request.Amount,
                    IDCategory = request.IDCategory,
                    PriceSale = request.PriceSale,
                    InterestProduct = request.InterestProduct,
                    SellMax = request.SellMax

                };
                _dataAccess.InsertProduct(param);
                result = true;
                return await Task.FromResult(result);

            }
            catch (Exception)
            {
                result = false;
                return await Task.FromResult(result);
            }
        }

        /// <summary>
        /// UpdateProduct
        /// </summary>
        /// <param name="request"></param>
        /// <returns>bool</returns>
        public async Task<bool> UpdateProduct(UpdateProductRequest request)
        {
            bool result = false;
            try
            {
                var param = new UpdateProductParameter()
                {
                    ID = request.ID,
                    NameProduct = request.NameProduct,
                    Price = request.Price,
                    BriefDes = request.BriefDes,
                    Description = request.Description,
                    ImageProduct = request.ImageProduct,
                    ImageProductDetail1 = request.ImageProductDetail1,
                    ImageProductDetail2 = request.ImageProductDetail2,
                    Amount = request.Amount,
                    IDCategory = request.IDCategory,
                    PriceSale = request.PriceSale,
                    InterestProduct = request.InterestProduct,
                    SellMax = request.SellMax

                };
                _dataAccess.UpdateProduct(param);
                result = true;
                return await Task.FromResult(result);

            }
            catch (Exception)
            {
                result = false;
                return await Task.FromResult(result);
            }
        }

        /// <summary>
        /// DeleteProduct
        /// </summary>
        /// <param name="request"></param>
        /// <returns>bool</returns>
        public async Task<bool> DeleteProduct(DeleteProductRequest request)
        {
            bool result = false;
            try
            {
                var param = new DeleteProductParameter()
                {
                    id = request.ID,

                };
                _dataAccess.DeleteProduct(param);
                result = true;
                return await Task.FromResult(result);

            }
            catch (Exception)
            {
                result = false;
                return await Task.FromResult(result);
            }
        }

        private GetProductAllResponse CheckTypeByPriceASC(GetProductAllParameter param)
        {
            var response = new GetProductAllResponse();
            try
            {
                var result = _dataAccess.GetListProductByPriceASC(param);
                if (result != null)
                {
                    response.ListProductAll = MapList<GETPRODUCT_BY_TYPE_PRICE_ASC_Result, GetProductAllDto>(result.ToList());
                    response.Success = true;
                }
            }
            catch (Exception)
            {
                response.Success = false;
            }
            return response;
        }

        private GetProductAllResponse CheckTypeByPriceDESC(GetProductAllParameter param)
        {
            var response = new GetProductAllResponse();
            try
            {
                var result = _dataAccess.GetListProductByPriceDESC(param);
                if (result != null)
                {
                    response.ListProductAll = MapList<GETPRODUCT_BY_TYPE_PRICE_DESC_Result, GetProductAllDto>(result.ToList());
                    response.Success = true;
                }
            }
            catch (Exception)
            {
                response.Success = false;
            }
            return response;
        }

        private GetProductAllResponse CheckTypeByDateASC(GetProductAllParameter param)
        {
            var response = new GetProductAllResponse();
            try
            {
                var result = _dataAccess.GetListProductByDateASC(param);
                if (result != null)
                {
                    response.ListProductAll = MapList<GETPRODUCT_BY_TYPE_DATE_ASC_Result, GetProductAllDto>(result.ToList());
                    response.Success = true;
                }
            }
            catch (Exception)
            {
                response.Success = false;
            }
            return response;
        }

        private GetProductAllResponse CheckTypeByDateDESC(GetProductAllParameter param)
        {
            var response = new GetProductAllResponse();
            try
            {
                var result = _dataAccess.GetListProductAll(param);
                if (result != null)
                {
                    response.ListProductAll = MapList<GETPRODUCTALL_Result, GetProductAllDto>(result.ToList());
                    response.Success = true;
                }
            }
            catch (Exception)
            {
                response.Success = false;
            }
            return response;
        }
    }
}