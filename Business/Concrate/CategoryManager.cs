using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrate.Repositories;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class CategoryMenager : ICategoryServ
    {
        ICategoryDal _categorydal;

        public CategoryMenager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public void CategoryDelete(Category category)
        {
            _categorydal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categorydal.Update(category);
        }

        public Category GetById(int id)
        {
            return _categorydal.Get(x => x.CategoryId == id);
        }

        public List<Category> GetList()
        {
            return _categorydal.List();
        }

        public void Insert(Category p)
        {
            _categorydal.Insert(p);
        }
    }
}
