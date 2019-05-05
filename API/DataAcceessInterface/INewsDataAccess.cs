using DataAcceessInterface.Parameter;
using EntityData;
using System.Collections.Generic;
namespace DataAcceessInterface
{
    public interface INewsDataAccess
    {
        IEnumerable<GET_NEWS_ALL_Result> GetAllNews();

        IEnumerable<GETNEWS_BY_DATE_Result> GetListNewsByDate();

        IEnumerable<GETNEWS_BY_VIEW_Result> GetListNewsByView();

        GETNEWSDETAIL_Result GetNewsDetail(GetNewsDetailParameter param);

        void Add_News(AddNewsParameter param);

        void Edit_News(EditNewsParameter param);

        void Delete_News(DeleteNewsParameter param);
    }
}