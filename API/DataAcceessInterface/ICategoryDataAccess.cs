using DataAcceessInterface.Parameter;
using EntityData;
using System.Collections.Generic;

namespace DataAcceessInterface
{
    public interface ICategoryDataAccess
    {
        IEnumerable<GETLISTCATEGORY_Result> GetListCategory();
        void AddCategory(AddCategoryParameter param );
        void EditCategory(UpdateCategoryParameter param);
        void DeleteCategory(DeleteCategoryParameter param);
    }
}