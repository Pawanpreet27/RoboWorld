using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboWorld.Models
{
   public interface IItemsRepository
    {
        IQueryable<CartItem> CartItems { get; }

        IQueryable<Item> Items { get; }

        Item DeleteItem(int itemId);
        void SaveItem(Item item);
    }
}
