using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using VehicleRegistrationSystem.Common.DataAccess;
using VehicleRegistrationSystem.DAL.Repository;

namespace VehicleRegistrationSystem.BLL.Managers
{
    public abstract class ManagerBase<T> : IDataAccess<T> where T : class
    {
        private Repository<T> repo = new Repository<T>();
        
        public virtual int Insert(T entity)
        {
            return repo.Insert(entity);
        }

        public virtual int Delete(T entity)
        {
            return repo.Delete(entity);
        }

        public virtual int Update(T entity)
        {
            return repo.Update(entity);
        }

        public virtual bool Any(Expression<Func<T, bool>> expression)
        {
            return repo.Any(expression);
        }

        public virtual T Find(Expression<Func<T, bool>> expression)
        {
            return repo.Find(expression);
        }

        public virtual List<T> GetList()
        {
            return repo.GetList();;
        }

        public virtual List<T> GetList(Expression<Func<T, bool>> expression)
        {
            return repo.GetList(expression);
        }

        public virtual void Dispose()
        {
            repo.Dispose();
        }

        public virtual int Save()
        {
            return repo.Save();
        }
    }
}