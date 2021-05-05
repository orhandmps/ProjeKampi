using DataAccess.Concrate.Repositories;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class CategoryMenager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAllB()
        {
            return repo.List();
        }

        public void CategoryAddB(Category p)
        {
            if (p.CategoryName=="" || p.CategoryName.Length<=3 || p.CategoryDescription=="" || p.CategoryName.Length>=51)
            {
                //hata mesajı
            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
