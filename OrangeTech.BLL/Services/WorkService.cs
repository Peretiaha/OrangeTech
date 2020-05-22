using AutoMapper;
using OrangeTech.BLL.Interfaces;
using OrangeTech.DAL.UnitOfWork;
using OrangeTech.Models.Models;
using System;
using System.Collections.Generic;

namespace OrangeTech.BLL.Services
{
    public class WorkService : IWorkService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IImageService _imageService;

        public WorkService(IUnitOfWork unitOfWork, IImageService imageService)
        {
            _unitOfWork = unitOfWork;
            _imageService = imageService;
        }

        public void Create(Work entity)
        {
            _unitOfWork.GetRepository<Work>().Insert(entity);
            _unitOfWork.Commit();
        }

        public void Delete(Guid entityId)
        {
            var entity = _unitOfWork.GetRepository<Work>().GetSingle(x => x.WorkId == entityId, x=>x.Images);
            _imageService.DeleteByWorkId(entityId);

            _unitOfWork.GetRepository<Work>().Delete(entity);
            _unitOfWork.Commit();
        }

        public IEnumerable<Work> GetAll()
        {
            var work = _unitOfWork.GetRepository<Work>().GetMany(null, null, x => x.Images);
            return work;
        }

        public Work GetById(Guid workId)
        {
            return _unitOfWork.GetRepository<Work>().GetSingle(x => x.WorkId == workId, x => x.Images);
        }

        public void Update(Work entity)
        {
            _unitOfWork.GetRepository<Work>().Update(entity);
            _unitOfWork.Commit();
        }
    }
}
