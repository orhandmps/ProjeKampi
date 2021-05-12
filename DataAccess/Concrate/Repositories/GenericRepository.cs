﻿using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context cnt = new Context();

        DbSet<T> _object;

        public GenericRepository()
        {
            _object = cnt.Set<T>();
        }

        public void Delete(T p)
        {
            _object.Remove(p);
            cnt.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public void Insert(T p)
        {
            _object.Add(p);
            cnt.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            cnt.SaveChanges();
        }
    }
}
