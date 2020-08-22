using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RoboWorld.Models
{
    public class CartItem
    {
        [Key]
        public int CartItemID { get; set; }
        public string CartItemName { get; set; }
        public double Price { get; set; }
        public string ImagePath { get; set; }
    }
}
