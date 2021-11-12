using dbConnectionTest.Models;
using System.Web.Mvc;

namespace dbConnectionTest.Controllers
{
    public class AuthorController : Controller
    {
        MAuthor mAuthor = new MAuthor();
        // GET: Author
        public ActionResult Index()
        {
            ViewBag.bookTypeList = mAuthor.BookTypeList();
            return View();
        }
        [HttpPost]
        public ActionResult Index(MAuthor mAuthor1)
        {
            ViewBag.bookTypeList = mAuthor1.BookTypeList();
            mAuthor1.InsertToDb(mAuthor1);
            return View();
        }
    }
}