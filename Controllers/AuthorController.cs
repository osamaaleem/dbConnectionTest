using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dbConnectionTest.Models;

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