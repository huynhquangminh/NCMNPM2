using System;

namespace BusinessLogicInterface.Dtos
{
    public class GetListNewsDto
    {
        public int ID { get; set; }
        public string NameNews { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<int> ViewMax { get; set; }
        public string UserName { get; set; }
        public string ImageNews { get; set; }
    }
}