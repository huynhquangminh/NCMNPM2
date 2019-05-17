namespace BusinessLogicInterface.Requests
{
    public class SendMailCommentCustomerRequest
    {
        public string NameCustomer { get; set; }
        public string EmailCustomer { get; set; }
        public string PassworkMailCustomer { get; set; }
        public string Content { get; set; }
    }
}