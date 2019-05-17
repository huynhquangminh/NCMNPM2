using BusinessLogicInterface;
using BusinessLogicInterface.Requests;
using System;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class MailBusinessLogic : IMailBusinessLogic
    {
        public MailBusinessLogic ()
        {

        }
        public async Task<bool> SendMailCommentCustomer(SendMailCommentCustomerRequest request)
        {
            //flippy2016@gmail.com
            var AddressMailWeb = "huynhtony08@gmail.com";
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(request.EmailCustomer);
                mail.To.Add(new MailAddress(AddressMailWeb));
                mail.Subject = request.NameCustomer + "phản hồi ";
                mail.Body = request.Content;
                mail.Priority = MailPriority.Normal;
                SmtpServer.Port = 25;
                SmtpServer.Credentials = new System.Net.NetworkCredential(request.EmailCustomer, request.PassworkMailCustomer);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                return await Task.FromResult(false);
            }

            return await Task.FromResult(true);
        }
    }
}