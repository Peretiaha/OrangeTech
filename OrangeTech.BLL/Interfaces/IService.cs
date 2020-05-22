using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeTech.BLL
{
    public interface IService<T> where T : class
    {
        public void Create(T entity);

        public void Update(T entity);

        public void Delete(Guid entityId);
    }
}
