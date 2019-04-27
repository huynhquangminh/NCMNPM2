namespace BusinessLogicInterface.Dtos
{
    public class ListCustomersDto
    {
        public int ID { get; set; }
        public string Telephone { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string NameCustomer { get; set; }
        public int RoleId { get; set; }
    }
}