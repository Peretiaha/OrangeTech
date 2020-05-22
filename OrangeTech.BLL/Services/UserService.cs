using AutoMapper;
using OrangeTech.BLL.Hash;
using OrangeTech.BLL.Interfaces;
using OrangeTech.DAL.UnitOfWork;
using OrangeTech.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeTech.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public bool Login(User user)
        {
            var savedPasswordHash = _unitOfWork.GetRepository<User>().GetSingle(u => u.Email == user.Email).Password;
            var hash = new Hashhing();
            if (hash.VerifyHashPassword(savedPasswordHash, user.Password))
            {
                user = _unitOfWork.GetRepository<User>().GetSingle(x => x.Email == user.Email);
                user.Role = _unitOfWork.GetRepository<Role>().GetSingle(x => x.RoleId == user.RoleId);

                return true;
            }

            return false;
        }        

        public User GetUserById(Guid userId)
        {
            var user = _unitOfWork.GetRepository<User>().GetSingle(x => x.UserId == userId);
            user.Role = _unitOfWork.GetRepository<Role>().GetSingle(x => x.RoleId == user.RoleId);

            return user;
        }

        public User GetUserByEmail(string email)
        {
            var user = _unitOfWork.GetRepository<User>().GetSingle(x => x.Email == email);
            user.Role = _unitOfWork.GetRepository<Role>().GetSingle(x => x.RoleId == user.RoleId);

            return user;
        }

        public void Create(User entity)
        {
            var hash = new Hashhing();
            entity.Password = hash.HashPassword(entity.Password);
            _unitOfWork.GetRepository<User>().Insert(entity);
            _unitOfWork.Commit();
        }      

        public void Delete(Guid id)
        {
            var entity = _unitOfWork.GetRepository<User>().GetSingle(x => x.UserId == id);
            _unitOfWork.GetRepository<User>().Delete(entity);
            _unitOfWork.Commit();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
