using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryServ
    {
        List<Category> GetList();

        void Insert(Category p);

        Category GetById(int id);

        void CategoryDelete(Category category);

        void CategoryUpdate(Category category);
    }
}
