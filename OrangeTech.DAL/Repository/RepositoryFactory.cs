using Autofac;

namespace OrangeTech.DAL.Repository
{
    public class RepositoryFactory : IRepositoryFactory
    {
        private readonly ILifetimeScope _lifetimeScope;

        public RepositoryFactory(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return _lifetimeScope.Resolve<IRepository<T>>();
        }
    }
}
