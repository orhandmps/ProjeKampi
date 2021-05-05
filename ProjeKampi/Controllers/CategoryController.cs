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
        public ActionResult Index()
        {
            return View();
        }

        void test(Category category)
        {
            using (var context = new Context())
            {
                if (string.IsNullOrWhiteSpace(category.name) rerun kaydetme;

                context.Categories.add(context);
                context.save();
            }
        }
    }
}