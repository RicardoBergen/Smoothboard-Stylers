using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace SmoothBoardStylers.Models
{
    public class QA
    {
        [Key, Required]
        public int QAId { get; set; }
        [Required]
        public string Vraag { get; set; }
        [Required]
        public string Antwoord { get; set; }
    }
}
