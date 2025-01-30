using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EzeCarVentures.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EzeCarVentures.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderRepo _orderRepo;
        private readonly ShoppingCart _shoppingCart;

        public OrderController(IOrderRepo orderRepo, ShoppingCart shoppingCart)
        {
            _orderRepo = orderRepo;
            _shoppingCart = shoppingCart;
        }

        // GET: /<controller>/
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, add some cars first");
            }

            if (ModelState.IsValid)
            {
                _orderRepo.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }
            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thanks for your order!";
            return View();
        }
    }
}
