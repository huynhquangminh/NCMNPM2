using DataAcceessInterface;
using EntityData;
using System.Collections.Generic;

namespace DataAccess
{
    public class HeaderDataAccess : IHeaderDataAccess
    {
        private readonly ConnectionStringDBShop db = new ConnectionStringDBShop();

        /// <summary>
        /// GetListSliderIMG
        /// </summary>
        /// <returns>GET_LIST_SLIDER_IMG_Result</returns>
        public IEnumerable<GET_LIST_SLIDER_IMG_Result> GetListSliderIMG()
        {
            return db.GET_LIST_SLIDER_IMG();
        }

        /// <summary>
        /// GetListBannerIMG
        /// </summary>
        /// <returns>GET_LIST_BANNER_IMG_Result</returns>
        public IEnumerable<GET_LIST_BANNER_IMG_Result> GetListBannerIMG()
        {
            return db.GET_LIST_BANNER_IMG();
        }
    }
}