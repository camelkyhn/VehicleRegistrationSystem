using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using VehicleRegistrationSystem.Common.DataAccess;
using VehicleRegistrationSystem.Common.Entities;

namespace VehicleRegistrationSystem.DAL.Repository
{
    public class Repository<T> : RepositoryBase, IDataAccess<T> where T : class
    {
        private DbSet<T> entitySet;

        public Repository()
        {
            entitySet = Context.Set<T>();
        }

        public int Insert(T entity)
        {
            entitySet.Add(entity);
            
            if (entity is Entity)
            {
                Entity e = entity as Entity;
                e.CreatedDate = DateTime.Now;
                e.UpdatedDate = DateTime.Now;
            }

            return Save();
        }

        public int Delete(T entity)
        {
            entitySet.Remove(entity);
            return Save();
        }

        public int Update(T entity)
        {
            if (entity is Entity)
            {
                Entity e = entity as Entity;
                e.UpdatedDate = DateTime.Now;
            }

            return Save();
        }

        public bool Any(Expression<Func<T, bool>> expression)
        {
            return entitySet.Any(expression);
        }

        public T Find(Expression<Func<T, bool>> expression)
        {
            return entitySet.FirstOrDefault(expression);
        }

        public List<T> GetList()
        {
            return entitySet.ToList();
        }

        public List<T> GetList(Expression<Func<T, bool>> expression)
        {
            return entitySet.Where(expression).ToList();
        }

        public void Dispose()
        {
            Context.Dispose();
            GC.SuppressFinalize(this);
        }

        public int Save()
        {
            return Context.SaveChanges();
        }
    }
}