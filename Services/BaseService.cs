using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Services
{
    internal class BaseService<T> : IBaseService<T> where T: class
    {
        private readonly NorthwindEntities _context;
        private DbSet<T> table;
        public BaseService(NorthwindEntities context)
        {
            _context = context;
            table = _context.Set<T>();
        }
        public void Add(T model)
        {
            table.Add(model);
        }

        public T Get(string id)
        {
            return table.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public void Remove(T model)
        {
            table.Remove(model);
        }

        public void Update(T model)
        {
            table.Attach(model);
            _context.Entry(model).State = System.Data.EntityState.Modified;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
