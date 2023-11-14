using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace codebased2.Models.repository
{
    public class repository<T> : irepository<T> where T:class
    {
        moviecontext mc;
        DbSet<T> dbset;
        public repository()
        {
            mc = new moviecontext();
            dbset = mc.Set<T>();
        }
            
        public void Delete(object dateofrelease)
        {
            T getModel = dbset.Find(dateofrelease);
            dbset.Remove(getModel);
            
        }

        public IEnumerable<T> GetAll()
        {
            return dbset.ToList();
            throw new NotImplementedException();
        }

        public T GetBydateofrelease(object dateofrelease)
        {
            return dbset.Find(dateofrelease);
            throw new NotImplementedException();
        }

        public void Insert(T obj)
        {
            dbset.Add(obj);
            throw new NotImplementedException();
        }

        public void save()
        {
            mc.SaveChanges();
            throw new NotImplementedException();
        }

        public void update(T obj)
        {
            mc.Entry(obj).State = EntityState.Modified;
            throw new NotImplementedException();
        }
    }
}