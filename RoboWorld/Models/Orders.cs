using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RoboWorld.Models
{
    public class Orders
    {
        [Key]
        public int OrderID { get; set; }

        [ForeignKey(nameof(User))]
        public int UserID { get; set; }
        public DateTime? OrderDate { get; set; }
        public String ShippingAddress { get; set; }

        [BindNever]
        public bool? IsDelivered { get; set; }
        public Cart Cart { get; set; }

    }
}
