using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoboWorld.Models;
using System.Linq;

namespace RoboWorld.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext context;

        public HomeController(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public ViewResult Index()
        {
            EFItemsRepository repo = new EFItemsRepository(context);
            return View("Home", repo.Items);
        }

        public ViewResult Home()
        {
            EFItemsRepository repo = new EFItemsRepository(context);
            return View(repo.Items);
        }

        public ViewResult Cart()
        {
            return View();
        }


        public ViewResult Login()
        {
            return View();
        }

        public ViewResult Privacy()
        {
            return View();
        }

        public ViewResult DeleteProduct(int itemId)
        {
            EFItemsRepository repo = new EFItemsRepository(context);
            repo.DeleteItem(itemId);
            return View("Home", repo.Items);
        }

        public ViewResult AddProduct()
        {
            return View("Add");
        }


        [Authorize]
        [HttpPost]
        public IActionResult AddProduct(Item product)
        {
            EFItemsRepository repo = new EFItemsRepository(context);
            if (ModelState.IsValid)
            {
                repo.SaveItem(product);
                TempData["message"] = $"{product.ItemName} has been added";
                return RedirectToAction("Index");
            }
            else
            {
                // There is something wrong with the data values
                return View(product);
            }
        }

        // Edit Action
        public ViewResult EditProduct(int itemId)
        {
            EFItemsRepository repo = new EFItemsRepository(context);
            return View("Edit", repo.Items.FirstOrDefault(p => p.ItemID == itemId));
        }

        [Authorize]
        [HttpPost]
        public IActionResult EditProduct(Item product)
        {
            EFItemsRepository repo = new EFItemsRepository(context);
            if (ModelState.IsValid)
            {
                repo.SaveItem(product);
                TempData["message"] = $"{product.ItemName} has been saved";
                return RedirectToAction("Index");
            }
            else
            {
                // There is something wrong with the data values
                return View("Edit", product);
            }
        }

        public ViewResult FilterProducts(string categoryName)
        {
            EFItemsRepository repo = new EFItemsRepository(context);
            return View("Home", repo.Items.Where(x => x.Category == categoryName).OrderBy(x => x));
        }

        public ViewResult ProductDetail(int itemId)
        {
            EFItemsRepository repo = new EFItemsRepository(context);
            return View("ProductDetail", repo.Items.FirstOrDefault(p => p.ItemID == itemId));
        }
    }
}
