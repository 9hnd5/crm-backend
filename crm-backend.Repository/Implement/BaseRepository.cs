using crm_backend.DataAccessLayer.EF;
using crm_backend.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crm_backend.Repository.Implement
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly CrmBackendDbContext _context;
        private DbSet<T> table;
        public BaseRepository(CrmBackendDbContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }
        public async Task<List<T>> GetAll()
        {
            var result = await (from x in table
                         select x).ToListAsync();
            return result;
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            var obj = table.Find(id);
            table.Remove(obj);
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
