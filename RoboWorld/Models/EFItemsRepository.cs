using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboWorld.Models
{
    public class EFItemsRepository : IItemsRepository
    {
        private ApplicationDbContext context;
        public EFItemsRepository(ApplicationDbContext cts)
        {
            context = cts;
        }

        public IQueryable<Item> Items => context.Items;

        public IQueryable<CartItem> CartItems => context.CartItems;

        public void SaveItem(Item item)
        {
            if (item.ItemID == 0)
            {
                context.Items.Add(item);
            }
            else
            {
                Item dbEntry = context.Items.FirstOrDefault(i => i.ItemID == item.ItemID);
                if (dbEntry != null)
                {
                    dbEntry.ItemName = item.ItemName;
                    dbEntry.Description = item.Description;
                    dbEntry.Price = item.Price;
                    dbEntry.ImagePath = item.ImagePath;
                    dbEntry.Category = item.Category;
                }
            }

            context.SaveChanges();
        }

        

        public void SaveCartItem(Item item)
        {
            
                Console.WriteLine("else executed");

                CartItem dbEntry = new CartItem();
               
                    dbEntry.CartItemName = item.ItemName;
                    dbEntry.Price = item.Price;
                    dbEntry.ImagePath = item.ImagePath;
            context.CartItems.Add(dbEntry);

            context.SaveChanges();
        }

        public Item DeleteItem(int itemID)
        {
            Item dbEntry = context.Items.FirstOrDefault(i => i.ItemID == itemID);
            
            if (dbEntry != null)
            {
                context.Items.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public CartItem DeleteCartItem(int itemID)
        {
            CartItem dbEntry = context.CartItems.FirstOrDefault(i => i.CartItemID == itemID);

            if (dbEntry != null)
            {
                context.CartItems.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

    }
}
