using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace ShopEshopperAPI.Controllers
{
    public class ImageController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage UploadImage()
        {
            HttpResponseMessage response = new HttpResponseMessage();
            var httpRequest = HttpContext.Current.Request;
            if (httpRequest.Files.Count > 0)
            {
                foreach (string file in httpRequest.Files)
                {
                    var postedFile = httpRequest.Files[file];
                    var filePath = HttpContext.Current.Server.MapPath("~/Image/" + postedFile.FileName);
                    postedFile.SaveAs(filePath);
                }
            }
            return response;
        }
    }
}