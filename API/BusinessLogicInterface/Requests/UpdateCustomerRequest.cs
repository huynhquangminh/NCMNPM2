namespace BusinessLogicInterface.Requests
{
    public class UpdateCustomerRequest
    {
        public int ID { get; set; }
        public string Telephone { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string NameCustomer { get; set; }
        public int RoleId { get; set; }
    }
}