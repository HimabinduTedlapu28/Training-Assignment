using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codebased2.Models.repository
{
    public interface irepository<T> where T:class
    {
        IEnumerable<T> GetAll();
        T GetBydateofrelease(object dateofrelease);
        void Insert(T obj);
        void update(T obj);
        void Delete(object dateofrelease);
        void save();
    }
}