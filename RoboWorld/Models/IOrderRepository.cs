using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboWorld.Models
{
    public interface IOrderRepository
    {
        IQueryable<Orders> Orders { get; }
        void SaveOrder(Orders order);
    }
}
