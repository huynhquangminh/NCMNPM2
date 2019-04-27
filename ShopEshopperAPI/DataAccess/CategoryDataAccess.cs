using DataAcceessInterface;
using DataAcceessInterface.Parameter;
using EntityData;
using System.Collections.Generic;

namespace DataAccess
{
    public class CategoryDataAccess : ICategoryDataAccess
    {
        private ConnectionStringDBShop db = new ConnectionStringDBShop();

        /// <summary>
        /// GetListCategory
        /// </summary>
        /// <returns> IEnumerable<GETLISTCATEGORY_Result> </returns>
        public IEnumerable<GETLISTCATEGORY_Result> GetListCategory()
        {
            return db.GETLISTCATEGORY();
        }

        /// <summary>
        /// AddCategory
        /// </summary>
        /// <param name="param">AddCategoryParameter</param>
        public void AddCategory (AddCategoryParameter param)
        {
            db.ADD_CATEGORY(param.nameCategory, param.imgCategory);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param">UpdateCategoryParamter</param>
        public  void EditCategory(UpdateCategoryParameter param)
        {
            db.EDIT_CATEGORY(param.id, param.nameCategory, param.imgCategory);
        }

        /// <summary>
        /// DeleteCategory
        /// </summary>
        /// <param name="param">DeleteCategoryParameter</param>
        public void DeleteCategory(DeleteCategoryParameter param)
        {
            db.DELETE_CATEGORY(param.id);
        }
    }
}