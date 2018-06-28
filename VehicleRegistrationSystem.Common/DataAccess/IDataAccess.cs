using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace VehicleRegistrationSystem.Common.DataAccess
{
    public interface IDataAccess<T>
    {
        int Insert(T entity);
        int Delete(T entity);
        int Update(T entity);
        bool Any(Expression<Func<T, bool>> expression);
        T Find(Expression<Func<T, bool>> expression);
        List<T> GetList();
        List<T> GetList(Expression<Func<T, bool>> expression);
        void Dispose();
        int Save();
    }
}