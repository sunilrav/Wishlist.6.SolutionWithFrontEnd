using Ninject.Modules;
using Wishlist.Core.Interfaces;

namespace Wishlist.Data.DependencyConfiguration
{
    public class DataNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
        }
    }
}
