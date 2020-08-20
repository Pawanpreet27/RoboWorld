using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboWorld.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private ApplicationDbContext context;
        public EFOrderRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Orders> Orders => context.Orders;

        public void SaveOrder(Orders order)
        {
            context.Orders.AddRange(order);
                if (order.OrderID == 0)
                {
                    context.Orders.Add(order);
                }
                context.SaveChanges();
        }
    }
}
