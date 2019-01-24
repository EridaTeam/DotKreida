using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotKreida.Contracts.Repositories {
    public interface IRepository<T> where T : class {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Create(T entity);
        void Update(T entity);
    }
}