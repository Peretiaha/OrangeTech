using OrangeTech.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeTech.BLL.Interfaces
{
    public interface IWorkService : IService<Work>
    {
        public IEnumerable<Work> GetAll();

        public Work GetById(Guid workId);
    }
}
