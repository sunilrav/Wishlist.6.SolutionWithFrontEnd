using System.Collections.Generic;
using System.Linq;
using Wishlist.Core.Domain;
using Wishlist.Core.Interfaces;

namespace Wishlist.Service
{
    public class WishlistService : IWishlistService
    {
        readonly IUnitOfWork _unitOfWork;

        public WishlistService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddWishlistItem(string description, int quantity)
        {
            var wishListItem = new WishListItem
            {
                Description = description,
                Quantity = quantity
            };

            using (_unitOfWork)
            {
                _unitOfWork.WishListItemRepository.Insert(wishListItem);
                _unitOfWork.Save();
            }
        }

        public IList<WishListItem> GetAllWishlistItems()
        {
            using (_unitOfWork)
            {
                return _unitOfWork.WishListItemRepository.GetAll().ToList();
            }
        }
    }
}
