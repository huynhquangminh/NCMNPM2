using BaseApplication;
using BusinessLogicInterface;
using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
using System.Web.Http;

namespace ShopEshopperAPI.Controllers
{
    public class ProductController : ApiController
    {
        private readonly IProductBusinessLogic _businessLogic;

        public ProductController(IProductBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }
            
        /// <summary>
        /// GetProductNew
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult GetProductIndex()
        {
            var result = _businessLogic.GetListProductIndex();
            return new ActionResult<GetProductIndexResponse>(result.Result, Request);
        }


        /// <summary>
        /// GetProductDetail
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult GetProductDetail(ProductDetailRequest RequestData)
        {
            var result = _businessLogic.GetProductDetailByID(RequestData);
            return new ActionResult<GetProductDetailResponse>(result.Result, Request);
        }

        /// <summary>
        /// GetProductByCategory
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult GetProductByCategory(GetProductByCategoryRequest RequestData)
        {
            var result = _businessLogic.GetProductByCategory(RequestData);
            return new ActionResult<GetProductAllResponse>(result.Result, Request);
        }

        /// <summary>
        /// GetProductAll
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult GetProductAll(GetProductAllRequest RequestData)
        {
            var result = _businessLogic.GetProductAll(RequestData);
            return new ActionResult<GetProductAllResponse>(result.Result, Request);
        }

        /// <summary>
        /// FindProduct
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult FindProduct(FindProductRequest RequestData)
        {
            var result = _businessLogic.FindProductByKey(RequestData);
            return new ActionResult<FindProductResponse>(result.Result, Request);
        }

        /// <summary>
        /// GetListProductAdmin
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult GetListProductAdmin(GetProductAllRequest RequestData)
        {
            var result = _businessLogic.GetListProductAdmin(RequestData);
            return new ActionResult<GetListProductAdminResponse>(result.Result, Request);
        }

        /// <summary>
        /// InsertProduct
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult InsertProduct(InsertProductRequest RequestData)
        {
            var result = _businessLogic.InsertProduct(RequestData);
            return new ActionResult<bool>(result.Result, Request);
        }


        /// <summary>
        /// UpdateProduct
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult UpdateProduct(UpdateProductRequest RequestData)
        {
            var result = _businessLogic.UpdateProduct(RequestData);
            return new ActionResult<bool>(result.Result, Request);
        }


        /// <summary>
        /// DeleteProduct
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult DeleteProduct(DeleteProductRequest RequestData)
        {
            var result = _businessLogic.DeleteProduct(RequestData);
            return new ActionResult<bool>(result.Result, Request);
        }
    }
}