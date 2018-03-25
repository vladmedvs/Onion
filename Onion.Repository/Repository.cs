using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Onion.Data;
using System.Linq;


namespace Onion.Repository
{
    public class Repository<T> : IRepository <T> where T :BaseEntity

    {
        private readonly ApplicationContext context;
        private DbSet<T> entittes;
        string errorMessage = string.Empty;

        public Repository(ApplicationContext context)
        {
            this.context = context;
            entittes = context.Set<T>();

        }
        public IEnumerable<T> GetAll()
        {
            return entittes.AsEnumerable();
        }

        public T Get(long id)
        {
            return entittes.SingleOrDefault(s => s.Id == id);
        }
        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entittes.Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entittes.Remove(entity);
            context.SaveChanges();
        }
        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entittes.Remove(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public IEnumerable<T> GrtAll()
        {
            throw new NotImplementedException();
        }

        public void inserd(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
