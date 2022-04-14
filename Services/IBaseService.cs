using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Services
{
    public interface IBaseService<T>
    {
        void Add(T model);
        void Remove(T model);
        void Update(T model);
        T Get(string id);
        IEnumerable<T> GetAll();
        void Save();

    }
}
