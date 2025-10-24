using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EscapeResturant.Models
{
    public class MenuItems
    {
        [Key]
        public int MenuItemId { get; set; } 
        public string MenuItemName { get; set; }

        public string MenuItemDesc { get; set; }

        public double price { get; set; }   

        public string ImageUrl { get; set; }

        public Boolean IsVegetarian { get; set; }

        public int MenuCatId { get; set; }

        [ForeignKey("MenuCatId")]

        public Boolean IsActive { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
