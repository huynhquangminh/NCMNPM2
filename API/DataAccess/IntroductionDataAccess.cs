using DataAcceessInterface;
using EntityData;
using System.Linq;

namespace DataAccess
{
    public class IntroductionDataAccess : IIntroductionDataAccess
    {
        private ConnectionStringDBShop db = new ConnectionStringDBShop();

        /// <summary>
        /// GetIntroduction
        /// </summary>
        /// <returns>GET_INTRODUCTION_Result</returns>
        public GET_INTRODUCTION_Result GetIntroduction()
        {
            return db.GET_INTRODUCTION().First();
        }
    }
}