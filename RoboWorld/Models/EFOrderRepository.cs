using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboWorld.Models
{
    public class EFOrderRepository 
    {
        private ApplicationDbContext context;
        public EFOrderRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<CartItem> CartItems => context.CartItems;


        public IQueryable<Item> Items => context.Items;

        public void SaveItem(CartItem item)
        {
            context.CartItems.Add(item);

   

            context.SaveChanges();
        }

        public CartItem DeleteItem(int itemID)
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
