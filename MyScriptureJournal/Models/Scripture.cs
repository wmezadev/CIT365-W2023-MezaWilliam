using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Scripture
    {
        public int ID { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Book { get; set; } = string.Empty;
        public int Chapter { get; set; }
        public string Verse { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;

        [Display(Name = "Entry Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; } = DateTime.Today;
    }
}
