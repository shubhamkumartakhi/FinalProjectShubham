using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EscapeResturant.Models
{
    public class MenuGeneration
    {
        [Key]
        public int MenuGenId { get; set; }

        public int  MenuCatId { get; set; }

        [ForeignKey("MenuCatId")]

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string  QRcode { get; set; }

        public DateOnly Date { get; set; }

    }
}
