using DataAcceessInterface;
using DataAcceessInterface.Parameter;
using EntityData;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class NewsDataAccess : INewsDataAccess
    {
        private readonly ConnectionStringDBShop db = new ConnectionStringDBShop();

        /// <summary>
        /// GetAllNews
        /// </summary>
        /// <returns>GET_NEWS_ALL_Result</returns>
        public IEnumerable<GET_NEWS_ALL_Result> GetAllNews()
        {
            return db.GET_NEWS_ALL();
        }
        /// <summary>
        /// GetListNewsByDate
        /// </summary>
        /// <returns>GETNEWS_BY_DATE_Result</returns>
        public IEnumerable<GETNEWS_BY_DATE_Result> GetListNewsByDate()
        {
            return db.GETNEWS_BY_DATE();
        }

        /// <summary>
        /// GetListNewsByView
        /// </summary>
        /// <returns>GETNEWS_BY_VIEW_Result</returns>
        public IEnumerable<GETNEWS_BY_VIEW_Result> GetListNewsByView()
        {
            return db.GETNEWS_BY_VIEW();
        }

        /// <summary>
        /// GetNewsDetail
        /// </summary>
        /// <param name="param">GetNewsDetailParameter</param>
        /// <returns>GETNEWSDETAIL_Result</returns>
        public GETNEWSDETAIL_Result GetNewsDetail(GetNewsDetailParameter param)
        {
            return db.GETNEWSDETAIL(param.id).First();
        }

        /// <summary>
        /// Add_News
        /// </summary>
        /// <param name="param">AddNewsParameter</param>
        public void Add_News(AddNewsParameter param)
        {
            db.ADD_NEWS(param.NameNews, param.IDCreater, param.Date, param.ImageNews, param.ImageNewDetail, param.ViewMax, param.DescriptionNews);
        }

        /// <summary>
        /// Edit_News
        /// </summary>
        /// <param name="param">EditNewsParameter</param>
        public void Edit_News(EditNewsParameter param)
        {
            db.EDIT_NEWS(param.ID,param.NameNews, param.IDCreater, param.Date, param.ImageNews, param.ImageNewDetail, param.ViewMax, param.DescriptionNews);
        }

        /// <summary>
        /// Delete_News
        /// </summary>
        /// <param name="param">DeleteNewsParameter</param>
        public void Delete_News(DeleteNewsParameter param)
        {
            db.DELETE_NEWS(param.id);
        }
    }
}