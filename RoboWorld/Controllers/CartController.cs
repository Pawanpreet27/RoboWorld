using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoboWorld.Models;

namespace RoboWorld.Controllers
{
    public class CartController : Controller
    {
        ApplicationDbContext context;

        public CartController(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            EFItemsRepository repo = new EFItemsRepository(context);
            return View("Cart", repo.CartItems);
        }

        public ViewResult DeleteProduct(int itemId)
        {
            EFItemsRepository repo = new EFItemsRepository(context);
            repo.DeleteCartItem(itemId);
            return View("Cart", repo.CartItems);
        }

        public ViewResult AddProduct(int itemId)
        {

            EFItemsRepository itemRepo = new EFItemsRepository(context);
            Item item = itemRepo.Items.FirstOrDefault((item) => item.ItemID == itemId);
            itemRepo.SaveCartItem(item);
            TempData["message"] = $"{item.ItemName} has been added to cart.";
            return View("Home", itemRepo.Items);
        }

        public ViewResult Checkout()
        {
            return View("ThanksUI");
        }
    }
}
