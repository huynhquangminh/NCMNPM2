using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicInterface.Dtos
{
   public class FindProductDto
    {
        public int ID { get; set; }
        public string NameProduct { get; set; }
        public decimal Price { get; set; }
        public string BriefDes { get; set; }
        public string ImageProduct { get; set; }
    }
}
