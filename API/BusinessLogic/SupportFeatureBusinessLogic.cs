using AutoMapper;
using BaseApplication;
using BusinessLogicInterface;
using BusinessLogicInterface.Dtos;
using BusinessLogicInterface.Requests;
using BusinessLogicInterface.Response;
using DataAcceessInterface;
using EntityData;
using System;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace BusinessLogic
{
    public class SupportFeatureBusinessLogic : BaseBusinessLogic, ISupportFeatureBusinessLogic
    {
        private readonly ISupportFeatureDataAccess _dataAccess;

        public SupportFeatureBusinessLogic(ISupportFeatureDataAccess dataAccess)
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
                cfg.CreateMap<GET_INFO_WEBSITE_Result, SupportFeatureDto>();
            });
            mapper = configMap.CreateMapper();
        }

        /// <summary>
        /// GetInfoWebSite
        /// </summary>
        /// <returns>SupportFeatureResponse</returns>
        public async Task<SupportFeatureResponse> GetInfoWebSite()
        {
            var response = new SupportFeatureResponse();
            try
            {
                var result = _dataAccess.GetInfoWebSite();
                if (result != null)
                {
                    response.infoWebSite = mapper.Map<GET_INFO_WEBSITE_Result, SupportFeatureDto>(result);
                    response.Success = true;
                }
            }
            catch (Exception )
            {
                response.Success = false;
            }
            return await Task.FromResult(response);
        }

        public async Task<bool> SendMailCommentCustomer(SendMailCommentCustomerRequest request)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(request.SendMailRequest.EmailCustomer);
                mail.To.Add(new MailAddress(request.SendMailRequest.AddressMailWeb));
                mail.Subject = request.SendMailRequest.NameCustomer + "phản hồi ";
                mail.Body = request.SendMailRequest.Content;
                mail.Priority = MailPriority.Normal;
                SmtpServer.Port = 25;
                SmtpServer.Credentials = new System.Net.NetworkCredential(request.SendMailRequest.EmailCustomer, request.SendMailRequest.PassworkMailCustomer);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            catch (Exception )
            {
                return await Task.FromResult(false);
            }
           

            return await Task.FromResult(true);
        }
    }
}