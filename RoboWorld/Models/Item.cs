using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RoboWorld.Models
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }
        [Required(ErrorMessage = "Please enter a product name")]
        public string ItemName { get; set; }

        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }
        [Range(0.01, double.MaxValue,
        ErrorMessage = "Please enter a positive price")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Please specify a category")]
        public string Category { get; set; }
        public string ImagePath { get; set; }
    }
}
