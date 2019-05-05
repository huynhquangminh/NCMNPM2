using EntityData;
using System.Collections.Generic;

namespace DataAcceessInterface
{
    public interface IHeaderDataAccess
    {
        IEnumerable<GET_LIST_SLIDER_IMG_Result> GetListSliderIMG();

        IEnumerable<GET_LIST_BANNER_IMG_Result> GetListBannerIMG();
    }
}