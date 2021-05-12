using Business.Concrate;
using Business.ValidationRules;
using DataAccess.EntityFramework;
using Entity.Concrate;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjeKampi.Controllers
{
    public class AdminCategoryController : Controller
    {
        // GET: AdminCategory
        CategoryMenager cm = new CategoryMenager(new EFCategoryDal());
        public ActionResult Index()
        {

            var categoryvalues = cm.GetList();
            return View(categoryvalues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            /*
             *Kategori tablosuna veri ekleme ve validationların kullanılması
             */
            CategoryValidatior cv = new CategoryValidatior();
            ValidationResult vr = cv.Validate(category);
            /*
             * 
             * Validation Hata Yakalama
             */
            if (vr.IsValid)
            {
                cm.Insert(category);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var x in vr.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
            }
            return View();
        }
        public ActionResult DeleteCategory(int id)
        {
            var categoryvalue = cm.GetById(id);
            cm.CategoryDelete(categoryvalue);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var categoryvalue = cm.GetById(id);
            return View(categoryvalue);
        }

        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            cm.CategoryUpdate(category);
            return View("Index");
        }

    }
}