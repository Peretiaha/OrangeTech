using OrangeTech.BLL.Interfaces;
using OrangeTech.DAL.UnitOfWork;
using OrangeTech.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeTech.BLL.Services
{
    public class ServiceService : IServiceService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IImageService _imageService;

        public ServiceService(IUnitOfWork unitOfWork, IImageService imageService)
        {
            _unitOfWork = unitOfWork;
            _imageService = imageService;
        }

        public void Create(Service entity)
        {
            _unitOfWork.GetRepository<Service>().Insert(entity);
            _unitOfWork.Commit();
        }

        public void Delete(Guid entityId)
        {
            var entity = _unitOfWork.GetRepository<Service>().GetSingle(x => x.ServiceId == entityId, x => x.Images);
            _imageService.DeleteByWorkId(entityId);

            _unitOfWork.GetRepository<Service>().Delete(entity);
            _unitOfWork.Commit();
        }

        public IEnumerable<Service> GetAll()
        {
            var services = _unitOfWork.GetRepository<Service>().GetMany(null, null, x => x.Images);
            return services;
        }

        public Service GetById(Guid serviceId)
        {
            return _unitOfWork.GetRepository<Service>().GetSingle(x => x.ServiceId == serviceId, x => x.Images);
        }

        public void Update(Service entity)
        {
            _unitOfWork.GetRepository<Service>().Update(entity);
            _unitOfWork.Commit();
        }
    }
}
