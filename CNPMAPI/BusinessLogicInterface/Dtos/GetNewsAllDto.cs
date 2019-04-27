using System;

namespace BusinessLogicInterface.Dtos
{
    public class GetNewsAllDto
    {
        public int ID { get; set; }
        public string NameNews { get; set; }
        public Nullable<int> IDCreater { get; set; }
        public System.DateTime Date { get; set; }
        public string ImageNews { get; set; }
        public string ImageNewDetail { get; set; }
        public Nullable<int> ViewMax { get; set; }
        public string DescriptionNews { get; set; }
    }
}