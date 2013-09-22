using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MvcPaging.Models;

namespace MvcPaging.Controllers
{
    public class BasePagingController : Controller
    {
        public ActionResult PostsPartial()
        {
            var model = GetModel(0);
            return PartialView("PostsPartial", model);
        }

        public JsonResult CheckPostsStatus(int currentPageNumber)
        {
            var posts = GetPosts();
            var totalPages = (int)Math.Ceiling((decimal)posts.Count() / 3);
            return Json((currentPageNumber + 1) < totalPages, JsonRequestBehavior.AllowGet);
        }

        protected PostViewModel GetModel(int currentPageNumber)
        {
            var posts = GetPosts();
            if (currentPageNumber == 0)
            {
                return new PostViewModel
                {
                    Posts = posts.Take(NumberOfPosts).ToList()
                };
            }

            var currentPage = currentPageNumber + 1;
            return new PostViewModel
            {
                Posts = posts.Skip((currentPage - 1) * NumberOfPosts).Take(NumberOfPosts).ToList()
            };
        }

        protected List<Post> GetPosts()
        {
            return Enumerable.Range(1, 15)
                             .Select(p => new Post
                             {
                                 PostId = p,
                                 PostTitle = "A sample post " + p,
                                 Category = p % 2 == 0 ? "ASP.Net" : "C#"
                             })
                             .ToList();
        }

        private const int NumberOfPosts = 3;
    }
}
