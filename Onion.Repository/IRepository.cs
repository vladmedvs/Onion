using System;
using System.Collections.Generic;
using System.Text;
using Onion.Data;

namespace Onion.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GrtAll();
        T Get(long id);
        void inserd(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();

    }
}
