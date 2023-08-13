using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryPattern.Core.Repository
{
    public interface IRepository<T> where T : class
    {
        public bool Add(T entity);
        public bool Update(T entity);
        public bool Delete(T entity);
        public IEnumerable<T> GetAll();
        public T FindById(int id);
    }
}
