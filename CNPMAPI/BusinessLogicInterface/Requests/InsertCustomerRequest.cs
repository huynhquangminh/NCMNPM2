using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicInterface.Requests
{
   public class InsertCustomerRequest
    {
        public string Telephone { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string NameCustomer { get; set; }
        public int RoleId { get; set; }
    }
}
