using DataAcceessInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityData;

namespace DataAccess
{
    public class PostsDataAccess:IPostsDataAcess
    {
        private HotelDbConnection db = new HotelDbConnection();
        /// <summary>
        /// GetRoomList
        /// </summary>
        /// <returns>GetRoomList</returns>
        public IEnumerable<GET_LIST_POSTS_Result> GetPostsList()
        {
            return db.GET_LIST_POSTS();
        }
    }
}
