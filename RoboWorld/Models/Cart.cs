
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoboWorld.Models
{
    public class Cart
    {
        [ForeignKey(nameof(User))]
        public int UserID { get; set; }

        [ForeignKey(nameof(Item))]
        public int ItemID { get; set; }

        public string ItemName { get; set; }
        [Key]
        public int CartLineID { get; set; }

        public int? Quantity { get; set; }
    }
}
