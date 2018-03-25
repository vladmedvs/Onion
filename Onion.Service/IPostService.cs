using System;
using System.Collections.Generic;
using System.Text;
using Onion.Data;


namespace Onion.Service
{
    public interface IPostService
    {
        IEnumerable<Post> GetPost();
        Post GetPost(long id);
        void InsertPost(Post post);
        void UpdatePost(Post post);
        void DeletePost(long id);
    }
}
