using OrangeTech.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeTech.BLL.Interfaces
{
    public interface IServiceService : IService<Service>
    {
        public IEnumerable<Service> GetAll();

        public Service GetById(Guid serviceId);
    }
}
