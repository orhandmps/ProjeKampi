using Business.Concrate;
using DataAccess.EntityFramework;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        CategoryMenager cm = new CategoryMenager(new EFCategoryDal());

        public ActionResult Index()
        {
            return View("");
        }
        public ActionResult GetCategoryList()
        {
            var categorylist = cm.GetList();
            return View(categorylist);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            cm.Insert(p);
            return RedirectToAction("GetCategoryList");
        }

    }
}