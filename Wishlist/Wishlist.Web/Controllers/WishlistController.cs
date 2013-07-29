using System.Web.Mvc;
using Wishlist.Service;
using Wishlist.Web.Models;

namespace Wishlist.Web.Controllers
{
    public class WishlistController : Controller
    {
        private readonly WishlistService _wishlistService;
        public WishlistController(WishlistService wishlistService)
        {
            _wishlistService = wishlistService;
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(WishListItemViewModel wishListItemViewModel)
        {
            _wishlistService.AddWishlistItem(wishListItemViewModel.Description, wishListItemViewModel.Quantity);
            return RedirectToAction("All");
        }

        public ActionResult All()
        {
            return View(_wishlistService.GetAllWishlistItems());
        }
    }
}
