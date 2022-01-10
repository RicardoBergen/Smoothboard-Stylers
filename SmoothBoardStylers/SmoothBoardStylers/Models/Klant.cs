using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace SmoothBoardStylers.Models
{
    public class Klant
    {
        [Key, Required]
        public int KlantenId { get; set; }
        [StringLength(30), Required()]
        public string Voornaam { get; set; }
        [StringLength(30), Required()]
        public string Achternaam { get; set; }
        [StringLength(50), Required()]
        public string Email { get; set; }
        [StringLength(5), Required()]
        public string Geslacht { get; set; }
        [StringLength(60), Required()]
        public string Land { get; set; }
        [Required()]
        public bool Inschrijven { get; set; }

    }
}
