namespace BusinessLogicInterface.Requests
{
    public class GetProductByCategoryRequest
    {
        public int IDCategory { get; set; }
        public int StartPage { get; set; }
    }
}