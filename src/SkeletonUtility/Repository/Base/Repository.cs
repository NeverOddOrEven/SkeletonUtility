using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SkeletonUtility.Repository.Base
{
    public interface IRepository<T>
        where T : Entity
    {
        long Add(T entity);
        void Delete(T entity);
        IEnumerable<T> Get(int max = 100);
        T Get(long id);
        IEnumerable<T> Get(Func<T, bool> predicate);
    }

    public abstract class Repository<T> : IRepository<T> 
        where T : Entity
    {
        private IList<T> MockStorage { get; set; }
        private long MockId;

        public Repository()
        {
            MockStorage = new List<T>();
        }

        public long Add(T entity)
        {
            var id = Interlocked.Increment(ref MockId);
            entity.Id = id;
            MockStorage.Add(entity);
            return id;
        }

        public void Delete(T entity)
        {
            MockStorage.Remove(entity);
        }

        public IEnumerable<T> Get(int max = 100)
        {
            return MockStorage.Take(max);
        }

        public T Get(long id)
        {
            return MockStorage.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<T> Get(Func<T, bool> predicate)
        {
            return MockStorage.Where(predicate);
        }
    }
}
