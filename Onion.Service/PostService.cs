using System;
using Onion.Data;
using Onion.Repository;
using System.Collections.Generic;

namespace Onion.Service
{
    public class PostService : IPostService
    {
        private IRepository<Post> PostRepository;
        private IRepository<Coments> Comentsepository;

        public PostService(IRepository<Post> PostRepository, IRepository<Coments> Comentsepository)
        {
            this.PostRepository = PostRepository;
            this.Comentsepository = Comentsepository;
        }

        public IEnumerable<Post> GetPost()
        {
            return PostRepository.GrtAll();
        
        }
        public Post GetUser(long id)
        {
            return PostRepository.Get(id);
        }

        public void InsertUser(Post post)
        {
            
            PostRepository.inserd(post);
        }
        public void UpdateUser(Post post)
        {
            PostRepository.Update(post);
        }

        public void DeleteUser(long id)
        {
            
            Coments coments = Comentsepository.Get(id);
            Comentsepository.Remove(coments);
            Post post = GetPost(id);
            PostRepository.Remove(post);
            PostRepository.SaveChanges();

        }

        public Post GetPost(long id)
        {
            throw new NotImplementedException();
        }

        public void InsertPost(Post post)
        {
            throw new NotImplementedException();
        }

        public void UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }

        public void DeletePost(long id)
        {
            throw new NotImplementedException();
        }
    }
}
