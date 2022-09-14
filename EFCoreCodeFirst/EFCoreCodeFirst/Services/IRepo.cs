using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Services
{
    public interface IRepo<K,T>
    {
        public T Add(T item);
        public IEnumerable<T> Get();
        public T GetByKey(K key);
        public T Update(K key, T Item);
        public T Delete(K key);
    }
}
