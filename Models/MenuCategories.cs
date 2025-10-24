using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace EscapeResturant.Models
{
    public class MenuCategories
    {
        [Key]
        public int MenuCatId { get; set; }

        public string MenuCatName { get; set; }

        public string Url { get; set; }

    } 
}
