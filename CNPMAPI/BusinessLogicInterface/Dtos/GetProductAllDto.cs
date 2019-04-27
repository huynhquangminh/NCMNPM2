using System;

namespace BusinessLogicInterface.Dtos
{
    public class GetProductAllDto
    {
        public Nullable<int> TotalRows { get; set; }
        public int ID { get; set; }
        public string NameProduct { get; set; }
        public decimal Price { get; set; }
        public Nullable<decimal> PriceSale { get; set; }
        public string BriefDes { get; set; }
        public string ImageProduct { get; set; }
        public string NameCategory { get; set; }
    }
}