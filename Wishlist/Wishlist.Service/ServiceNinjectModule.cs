using Ninject.Modules;
using Wishlist.Core.Interfaces;

namespace Wishlist.Service
{
    public class ServiceNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IWishlistService>().To<WishlistService>();
        }
    }
}
