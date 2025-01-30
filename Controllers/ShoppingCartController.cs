using EzeCarVentures.Models;
using EzeCarVentures.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EzeCarVentures.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ICar _carRepo;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ICar carRepo, ShoppingCart shoppingCart)
        {
            _carRepo = carRepo;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int carId)
        {
            var selectedCar = _carRepo.AllCars.FirstOrDefault(p => p.CarId == carId);

            if (selectedCar != null)
            {
                _shoppingCart.AddToCart(selectedCar, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int carId)
        {
            var selectedCar = _carRepo.AllCars.FirstOrDefault(p => p.CarId == carId);

            if (selectedCar != null)
            {
                _shoppingCart.RemoveFromCart(selectedCar);
            }
            return RedirectToAction("Index");
        }
    }
}
