using EntityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcceessInterface
{
    public interface IPostsDataAcess
    {
        /// <summary>
        /// GetPostsList
        /// </summary>
        /// <returns>GET_POSTS_Result</returns>
        IEnumerable<GET_LIST_POSTS_Result> GetPostsList();
    }
}
