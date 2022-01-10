using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace SmoothBoardStylers.Models
{
    public class Bestelling
    {
        [Key, Required]
        public int BestellingsId { get; set; }
        [ForeignKey("Klant"), Display(Name = "Klant")]
        public int KlantID { get; set; }
        [ForeignKey("Product"), Display(Name = "Product")]
        public int ProductID { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}"), Required]
        public DateTime Datum { get; set; }
    }
}
