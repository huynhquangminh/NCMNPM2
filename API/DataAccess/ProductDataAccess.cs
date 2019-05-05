using DataAcceessInterface;
using DataAcceessInterface.Parameter;
using EntityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDataAccess : IProductDataAccess
    {
        private readonly ConnectionStringDBShop db = new ConnectionStringDBShop();

        /// <summary>
        /// GetListProductNew
        /// </summary>
        /// <returns>GETPRODUCT_NEWS_Result</returns>
        public IEnumerable<GETPRODUCT_NEWS_Result> GetListProductNew()
        {
            return db.GETPRODUCT_NEWS();
        }

        /// <summary>
        /// GetListProductSellMax
        /// </summary>
        /// <returns>GETLISTPRODUCT_SELLMAX_Result</returns>
        public IEnumerable<GETLISTPRODUCT_SELLMAX_Result> GetListProductSellMax()
        {
            return db.GETLISTPRODUCT_SELLMAX();
        }

        /// <summary>
        /// GetListProductInterestProcduct
        /// </summary>
        /// <returns>GETLISTPRODUCT_INTEREST_Result</returns>
        public IEnumerable<GETLISTPRODUCT_INTEREST_Result> GetListProductInterestProcduct()
        {
            return db.GETLISTPRODUCT_INTEREST();
        }

        /// <summary>
        /// GetListProductPriceSale
        /// </summary>
        /// <returns>GETLISTPRODUCT_PRICESALE_Result</returns>
        public IEnumerable<GETLISTPRODUCT_PRICESALE_Result> GetListProductPriceSale()
        {
            return db.GETLISTPRODUCT_PRICESALE();
        }

        /// <summary>
        /// GetProductDetailByID
        /// </summary>
        /// <param name="param">ProductDetailByIDParameter </param>
        /// <returns>GETPRODUCTDETAIL_BY_ID_Result </returns>
        public GETPRODUCTDETAIL_BY_ID_Result GetProductDetailByID(ProductDetailByIDParameter param)
        {
            return db.GETPRODUCTDETAIL_BY_ID(param.ID).First();
        }

        /// <summary>
        /// GetListProductByCategory
        /// </summary>
        /// <param name="param">GetProductByCategoryParameter</param>
        /// <returns>GET_PRODUCT_BY_CATEGORY_Result</returns>
        public IEnumerable<GET_PRODUCT_BY_CATEGORY_Result> GetListProductByCategory(GetProductByCategoryParameter param)
        {
            return db.GET_PRODUCT_BY_CATEGORY(param.IDCategory, param.StartPage);
        }

        /// <summary>
        /// GetListProductAll
        /// </summary>
        /// <param name="param">GetProductAllParameter</param>
        /// <returns>GETPRODUCTALL_Result</returns>
        public IEnumerable<GETPRODUCTALL_Result> GetListProductAll(GetProductAllParameter param)
        {
            return db.GETPRODUCTALL(param.StartPage);
        }

        /// <summary>
        /// GetListProductByPriceASC
        /// </summary>
        /// <param name="param">GetProductAllParameter</param>
        /// <returns>GETPRODUCT_BY_TYPE_PRICE_ASC_Result</returns>
        public IEnumerable<GETPRODUCT_BY_TYPE_PRICE_ASC_Result> GetListProductByPriceASC(GetProductAllParameter param)
        {
            return db.GETPRODUCT_BY_TYPE_PRICE_ASC(param.StartPage);
        }

        /// <summary>
        /// GetListProductByPriceASC
        /// </summary>
        /// <param name="param">GetProductAllParameter</param>
        /// <returns>GETPRODUCT_BY_TYPE_PRICE_DESC_Result</returns>
        public IEnumerable<GETPRODUCT_BY_TYPE_PRICE_DESC_Result> GetListProductByPriceDESC(GetProductAllParameter param)
        {
            return db.GETPRODUCT_BY_TYPE_PRICE_DESC(param.StartPage);
        }

        /// <summary>
        /// GetListProductByDateASC
        /// </summary>
        /// <param name="param">GetProductAllParameter</param>
        /// <returns>GETPRODUCT_BY_TYPE_DATE_ASC_Result</returns>
        public IEnumerable<GETPRODUCT_BY_TYPE_DATE_ASC_Result> GetListProductByDateASC(GetProductAllParameter param)
        {
            return db.GETPRODUCT_BY_TYPE_DATE_ASC(param.StartPage);
        }

        /// <summary>
        /// FindProduct
        /// </summary>
        /// <param name="param">FindProductParameter</param>
        /// <returns>FIND_PRODUCT_Result</returns>
        public IEnumerable<FIND_PRODUCT_Result> FindProduct(FindProductParameter param)
        {
            var result = db.FIND_PRODUCT(param.key);
            return db.FIND_PRODUCT(param.key);
        }

        /// <summary>
        /// GetListProduct
        /// </summary>
        /// <returns>GET_LISTPRODUCT_ALL_Result</returns>
        public IEnumerable<GET_LISTPRODUCT_ALL_Result> GetListProductAdmin(GetProductAllParameter param)
        {
            return db.GET_LISTPRODUCT_ALL(param.StartPage);
        }

        public void InsertProduct(InsertProductParameter param)
        {
            db.INSERT_PRODUCT(param.NameProduct, param.Price, param.BriefDes, param.Description, param.ImageProduct, param.ImageProductDetail1, param.ImageProductDetail2, param.Amount, param.IDCategory, param.PriceSale, param.InterestProduct, param.SellMax);
        }

        public void UpdateProduct(UpdateProductParameter param)
        {
            db.UPDATE_PRODUCT(param.ID,param.NameProduct, param.Price, param.BriefDes, param.Description, param.ImageProduct, param.ImageProductDetail1, param.ImageProductDetail2, param.Amount, param.IDCategory, param.PriceSale, param.InterestProduct, param.SellMax);
        }

        public void DeleteProduct(DeleteProductParameter param)
        {
            db.DETELET_PRODUCT(param.id);
        }
    }
}
