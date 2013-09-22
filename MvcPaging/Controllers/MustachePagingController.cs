using System.Web.Mvc;

namespace MvcPaging.Controllers
{
    public class MustachePagingController : BasePagingController
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult LoadMorePosts(int currentPageNumber)
        {
            var model = GetModel(currentPageNumber);
            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}
