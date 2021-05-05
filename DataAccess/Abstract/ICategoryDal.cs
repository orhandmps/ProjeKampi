using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICategoryDal
    {
        List<Category> List();

        void Insert(Category p);

        void Update(Category p);

        void Delete(Category p);
    }
}
