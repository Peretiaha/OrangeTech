using OrangeTech.DAL.Context;
using OrangeTech.DAL.Repository;

namespace OrangeTech.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OrangeTechContext _db;

        private readonly IRepositoryFactory _repositoryFactory;

        public UnitOfWork(OrangeTechContext db, IRepositoryFactory repositoryFactory)
        {
            _db = db;
            _repositoryFactory = repositoryFactory;
        }

        public void Commit()
        {
            _db.SaveChanges();
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return _repositoryFactory.GetRepository<T>();
        }
    }
}
