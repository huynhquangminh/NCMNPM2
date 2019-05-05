using DataAcceessInterface.Parameter;
using EntityData;
using System.Collections.Generic;

namespace DataAcceessInterface
{
    public interface IProductDataAccess
    {
        IEnumerable<GETPRODUCT_NEWS_Result> GetListProductNew();

        IEnumerable<GETLISTPRODUCT_SELLMAX_Result> GetListProductSellMax();

        IEnumerable<GETLISTPRODUCT_INTEREST_Result> GetListProductInterestProcduct();

        IEnumerable<GETLISTPRODUCT_PRICESALE_Result> GetListProductPriceSale();

        GETPRODUCTDETAIL_BY_ID_Result GetProductDetailByID(ProductDetailByIDParameter param);

        IEnumerable<GET_PRODUCT_BY_CATEGORY_Result> GetListProductByCategory(GetProductByCategoryParameter param);

        IEnumerable<GETPRODUCTALL_Result> GetListProductAll(GetProductAllParameter param);

        IEnumerable<GETPRODUCT_BY_TYPE_PRICE_ASC_Result> GetListProductByPriceASC(GetProductAllParameter param);

        IEnumerable<GETPRODUCT_BY_TYPE_PRICE_DESC_Result> GetListProductByPriceDESC(GetProductAllParameter param);

        IEnumerable<GETPRODUCT_BY_TYPE_DATE_ASC_Result> GetListProductByDateASC(GetProductAllParameter param);

        IEnumerable<FIND_PRODUCT_Result> FindProduct(FindProductParameter param);

        IEnumerable<GET_LISTPRODUCT_ALL_Result> GetListProductAdmin(GetProductAllParameter param);

        void InsertProduct(InsertProductParameter param);

        void UpdateProduct(UpdateProductParameter param);

        void DeleteProduct(DeleteProductParameter param);



    }
}