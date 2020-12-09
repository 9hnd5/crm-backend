using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace crm_backend.Repository.Interface
{
    public interface IBaseRepository<T> where T: class
    {
        Task<List<T>> GetAll();
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void SaveChanges();
    }
}
