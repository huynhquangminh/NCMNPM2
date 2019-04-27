using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicInterface.Dtos
{
   public class GetNewsDetailDto
    {
        public int ID { get; set; }
        public string NameNews { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<int> ViewMax { get; set; }
        public string UserName { get; set; }
        public string ImageNews { get; set; }
        public string DescriptionNews { get; set; }
    }
}
