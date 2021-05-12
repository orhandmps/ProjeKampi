using DataAccess.Abstract;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.Repositories
{
    public class CategoryRepository : IRepository<Category> 
    {
        Context cnt = new Context();
        DbSet<Category> _object;

        public void Delete(Category p)
        {
            _object.Remove(p);
            cnt.SaveChanges();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category p)
        {
            _object.Add(p);
            cnt.SaveChanges();
        }

        public List<Category> List()
        {
            return _object.ToList();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            cnt.SaveChanges();
        }
    }
}
