using AutoMapper;
using BaseApplication;
using BusinessLogicInterface;
using BusinessLogicInterface.Dtos;
using BusinessLogicInterface.Response;
using DataAcceessInterface;
using EntityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
  public  class HeaderBusinessLogic: BaseBusinessLogic, IHeaderBusinessLogic
    {
        private readonly IHeaderDataAccess _dataAccess;
        public HeaderBusinessLogic(IHeaderDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
            ConfigAutoMapper();
        }

        /// <summary>
        /// ConfigAutoMapper
        /// </summary>
        public override void ConfigAutoMapper()
        {
            configMap = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<GET_LIST_BANNER_IMG_Result, GetListHeaderDto>();
                cfg.CreateMap<GET_LIST_SLIDER_IMG_Result, GetListHeaderDto>();
            });
            mapper = configMap.CreateMapper();
        }

      public async  Task<GetListHeaderResponse> GetListHeader()
        {
            var response = new GetListHeaderResponse();
            try
            {
                var resultSlider = _dataAccess.GetListSliderIMG();
                var resultBanner = _dataAccess.GetListBannerIMG();
                if (resultSlider != null && resultBanner != null)
                {
                    response.GetListSlider = MapList<GET_LIST_SLIDER_IMG_Result, GetListHeaderDto>(resultSlider.ToList());
                    response.GetListBanner = MapList<GET_LIST_BANNER_IMG_Result, GetListHeaderDto>(resultBanner.ToList());
                    response.Success = true;
                }

            }
            catch (Exception)
            {
                response.Success = false;
            }
            return await Task.FromResult(response);
        }
    }
}
