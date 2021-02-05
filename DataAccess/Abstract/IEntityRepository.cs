using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Generic constraint
    //class : referance
    //IEntity veya onu implemente eden bir nesne
    //new() : newlenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
