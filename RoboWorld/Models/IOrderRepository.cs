using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboWorld.Models
{
    public interface IOrderRepository
    {
        IQueryable<Item> CartItems{ get; }
        void SaveOrder(Item cartItem);
    }
}
