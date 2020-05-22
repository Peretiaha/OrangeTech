using OrangeTech.DAL.Repository;

namespace OrangeTech.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Commit();

        IRepository<T> GetRepository<T>() where T : class;
    }
}
