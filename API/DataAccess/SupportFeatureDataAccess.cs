using DataAcceessInterface;
using EntityData;
using System.Linq;

namespace DataAccess
{
    public class SupportFeatureDataAccess : ISupportFeatureDataAccess
    {
        private readonly ConnectionStringDBShop db = new ConnectionStringDBShop();

        /// <summary>
        /// GetInfoWebSite
        /// </summary>
        /// <returns>GET_INFO_WEBSITE_Result</returns>
        public GET_INFO_WEBSITE_Result GetInfoWebSite()
        {
            return db.GET_INFO_WEBSITE().First();
        }
    }
}