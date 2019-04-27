using System;

namespace BusinessLogicInterface.Dtos
{
    public class GetListProductAdminDto
    {
        public Nullable<int> TotalRows { get; set; }
        public int ID { get; set; }
        public string NameProduct { get; set; }
        public decimal Price { get; set; }
        public string BriefDes { get; set; }
        public string Description { get; set; }
        public string ImageProduct { get; set; }
        public string ImageProductDetail1 { get; set; }
        public string ImageProductDetail2 { get; set; }
        public int Amount { get; set; }
        public System.DateTime Date { get; set; }
        public int IDCategory { get; set; }
        public decimal PriceSale { get; set; }
        public int InterestProduct { get; set; }
        public int SellMax { get; set; }
    }
}