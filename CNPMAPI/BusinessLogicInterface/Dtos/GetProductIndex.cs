using System;

namespace BusinessLogicInterface.Dtos
{
    public  class GetProductIndex
    {
        public int ID { get; set; }
        public string NameProduct { get; set; }
        public string ImageProduct { get; set; }
        public decimal Price { get; set; }
        public Nullable<decimal> PriceSale { get; set; }
    }
}