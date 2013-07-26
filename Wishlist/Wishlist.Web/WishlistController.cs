using System.Web.Mvc;
using Wishlist.Service;
using Wishlist.Web.Models;

namespace Wishlist.Web
{
    public class WishlistController : Controller
    {
        private readonly WishlistService _wishlistService;
        public WishlistController(WishlistService wishlistService)
        {
            _wishlistService = wishlistService;
        }

        public ActionResult Add(WishListItemViewModel wishListItemViewModel)
        {
            _wishlistService.AddWishlistItem(wishListItemViewModel.Description, wishListItemViewModel.Quantity);
            return RedirectToAction("All");
        }

        public ActionResult All()
        {
            _wishlistService.GetAllWishlistItems();
            return View();
        }
    }
}
