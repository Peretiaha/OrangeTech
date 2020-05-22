using OrangeTech.BLL.Interfaces;
using OrangeTech.DAL.UnitOfWork;
using OrangeTech.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeTech.BLL.Services
{
    public class RoleService : IRoleService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(Role entity)
        {
            _unitOfWork.GetRepository<Role>().Insert(entity);
            _unitOfWork.Commit();
        }

        public void Delete(Guid entityId)
        {
            var entity = _unitOfWork.GetRepository<Role>().GetSingle(x=>x.RoleId == entityId);
            _unitOfWork.GetRepository<Role>().Delete(entity);
            _unitOfWork.Commit();
        }

        public Role GetByName(string name)
        {
            return _unitOfWork.GetRepository<Role>().GetSingle(x => x.Name == name);
        }

        public void Update(Role entity)
        {
            _unitOfWork.GetRepository<Role>().Update(entity);
            _unitOfWork.Commit();
        }
    }
}
