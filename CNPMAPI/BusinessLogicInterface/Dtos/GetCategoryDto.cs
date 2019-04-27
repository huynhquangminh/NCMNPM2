using System;

namespace BusinessLogicInterface.Dtos
{
    public class GetCategoryDto
    {
        public int ID { get; set; }
        public string NameCategory { get; set; }
        public string ImageCategory { get; set; }
    }
}