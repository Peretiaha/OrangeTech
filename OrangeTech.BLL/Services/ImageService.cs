using AutoMapper;
using OrangeTech.BLL.Interfaces;
using OrangeTech.DAL.UnitOfWork;
using OrangeTech.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeTech.BLL.Services
{
    public class ImageService : IImageService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ImageService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void DeleteByWorkId(Guid workId)
        {
            var entities = _unitOfWork.GetRepository<Image>().GetMany(x => x.WorkId == workId);
            foreach(var entity in entities)
            {
                _unitOfWork.GetRepository<Image>().Delete(entity);
            }

            _unitOfWork.Commit();
        }
    }
}
