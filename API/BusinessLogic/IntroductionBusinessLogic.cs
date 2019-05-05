using AutoMapper;
using BaseApplication;
using BusinessLogicInterface;
using BusinessLogicInterface.Dtos;
using BusinessLogicInterface.Response;
using DataAcceessInterface;
using EntityData;
using System;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class IntroductionBusinessLogic : BaseBusinessLogic, IIntroductionBusinessLogic
    {
        private readonly IIntroductionDataAccess _dataAccess;

        public IntroductionBusinessLogic(IIntroductionDataAccess dataAccess)
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
                cfg.CreateMap<GET_INTRODUCTION_Result, GetIntroductionDto>();
            });
            mapper = configMap.CreateMapper();
        }

        /// <summary>
        /// GetIntroduction
        /// </summary>
        /// <returns>GetIntroductionResponse</returns>
        public async Task<GetIntroductionResponse> GetIntroduction()
        {
            var response = new GetIntroductionResponse();
            try
            {
                var result = _dataAccess.GetIntroduction();
                if (result != null)
                {
                    response.Introduction = mapper.Map<GET_INTRODUCTION_Result, GetIntroductionDto>(result);
                    response.Success = true;
                }
            }
            catch (Exception )
            {
                response.Success = false;
            }
            return await Task.FromResult(response);
        }
    }
}