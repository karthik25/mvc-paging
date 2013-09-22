using System.Web.Mvc;

namespace MvcPaging.Controllers
{
    public class MvcPagingController : BasePagingController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoadMorePosts(int currentPageNumber)
        {
            var model = GetModel(currentPageNumber);
            return PartialView("PostDisplayer", model);
        }
    }
}
