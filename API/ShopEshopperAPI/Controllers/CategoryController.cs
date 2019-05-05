using BaseApplication;
using BusinessLogicInterface;
using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
using System.Web.Http;

namespace ShopEshopperAPI.Controllers
{
    public class CategoryController : ApiController
    {
        private readonly ICategoryBusinessLogic _businessLogic;

        public CategoryController(ICategoryBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        /// <summary>
        /// GetCategoryAll
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost] 
        public IHttpActionResult GetCategoryAll()
        {
            var result = _businessLogic.GetListCategory();
            return new ActionResult<GetCategoryResponse>(result.Result, Request);
        }


        /// <summary>
        /// GetCategoryAll
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult AddCategory(AddCategoryRequest request)
        {
            var result = _businessLogic.AddCategory(request);
            return new ActionResult<bool>(result.Result, Request);
        }


        /// <summary>
        /// EditCategory
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult EditCategory(EditCategoryRequest request)
        {
            var result = _businessLogic.EditCategory(request);
            return new ActionResult<bool>(result.Result, Request);
        }


        /// <summary>
        /// DeleteCategory
        /// </summary>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        public IHttpActionResult DeleteCategory(DeleteCategoryRequest request)
        {
            var result = _businessLogic.DeleteCategory(request);
            return new ActionResult<bool>(result.Result, Request);
        }
    }
}