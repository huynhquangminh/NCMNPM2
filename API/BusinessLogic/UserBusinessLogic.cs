using AutoMapper;
using BaseApplication;
using BusinessLogicInterface;
using BusinessLogicInterface.Dtos;
using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
using DataAcceessInterface;
using EntityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcceessInterface.Parameter;

namespace BusinessLogic
{
    public class UserBusinessLogic: BaseBusinessLogic, IUserBusinessLogic
    {
        private readonly IUserDataAccess _dataAccess;

        public UserBusinessLogic(IUserDataAccess dataAccess)
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
                cfg.CreateMap<USER_LOGIN_Result, UserLoginDTO>();
            });
            mapper = configMap.CreateMapper();
        }

        /// <summary>
        /// UserLoginResponse
        /// </summary>
        /// <returns>UserLogin</returns>
        public async Task<UserLoginResponse> UserLogin(UserLoginRequest request)
        {
            var response = new UserLoginResponse();
            
            try
            {
                var param = new UserLoginParameter()
                {
                    userName = request.userName,
                    password = request.password
                };
                var result = _dataAccess.UserLogin(param);
                if (result != null)
                {
                    response.UserInfo = MapList<USER_LOGIN_Result, UserLoginDTO>(result.ToList());
                    response.Success = true;
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
            }
            return await Task.FromResult(response);
        }

        /// <summary>
        /// UserRegister
        /// </summary>
        /// <returns>bool</returns>
        public async Task<bool> UserRegister(UserRegisterRequest request)
        {
            bool result = false;
            try
            {
                var param = new UserRegisterParameter()
                {
                   tenNhanVien=request.tenNhanVien,
                   userName=request.userName,
                   password=request.password,
                   cMND=request.cMND,
                   idLoaiNV=request.idLoaiNV,
                   sDT=request.sDT,
                   address=request.address
                };
                _dataAccess.UserRegister(param);
                result = true;
                return result;
            }
            catch (Exception ex)
            {
                result = false;
                return result;
            }
            return await Task.FromResult(result);
        }

    }
}
