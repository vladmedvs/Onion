using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Onion.Data;
using Onion.Repository;
using Onion.Service;
using Onion.Web.Models;

namespace Onion.Web.Controlers
{
    public class PostController : Controller
    {
        private readonly IComentsService comentsService;
        private readonly IPostService postService;
        public PostController(IPostService postService, IComentsService comentsService)
        {
            this.postService = postService;
            this.comentsService = comentsService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<PostVievModel> model = new List<PostVievModel>();
            postService.GetPost().ToList().ForEach(p =>
           {
               Coments coments = comentsService.GetComents(p.Id);
               PostVievModel post = new PostVievModel
               {
                   Id = p.Id,
                   UserName = $"{p}",
                  // UserPost = post.UserPost

               };
               model.Add(post);


           });

            return View(model);

        }

        [HttpGet]
        public ActionResult AddPost(PostVievModel model)
        {
            Post postEntity = new Post
            {
                UserName = model.UserName,
                UserPost = model.UserPost,
                AddData = DateTime.UtcNow,
                ModData = DateTime.UtcNow,
                IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                Coments = new Coments
                {
                    User = model.UserName,
                    Text = model.UserPost,
                    AddData = DateTime.UtcNow,
                    ModData = DateTime.UtcNow,
                    IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                }
            };
            postService.InsertPost(postEntity);
            if(postEntity.Id>0)
            {
                return RedirectToAction("index");
            }
            return View(model);
            
        }

        public AcceptedResult EditUser(int ? id)
        {
            PostVievModel model = new PostVievModel();
            if (id.HasValue && id != 0)
            {
                Post postEntity = postService.GetPost(id.Value);
                Coments comentsEntity = comentsService.GetComents(id.Value);
                model.UserName = postEntity.UserName;
                model.UserPost = postEntity.UserPost;
            }
            
            
            return PartialView("_EditPost", model);
        }
        [HttpPost]
        public ActionResult EditPost(PostVievModel model)
        {
            Post postEntity = postService.GetPost(model.Id);
            postEntity.UserName = model.UserName;
            postEntity.ModData = DateTime.UtcNow;
            postEntity.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            Coments comentsEntity = comentsService.GetComents(model.Id);
            comentsEntity.User = model.UserName;
            comentsEntity.Text = model.UserPost;
            comentsEntity.ModData = DateTime.UtcNow;
            comentsEntity.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            postEntity.Coments = comentsEntity;
            postService.UpdatePost(postEntity);
            if (postEntity.Id > 0)
            {
                return RedirectToAction("index");
            }
            return View(model);
        }

        [HttpGet]
        public PartialViewResult DeletePost(int id)
        {
            Post post = postService.GetPost(id);
            string name = $"{post.UserPost} {post.UserName}";
            return PartialView("_DeleteUser", name);
        }

        [HttpPost]
        public ActionResult DeletePost(long id, FormCollection form)
        {
            postService.DeletePost(id);
            return RedirectToAction("Index");
        }
        
    }
}