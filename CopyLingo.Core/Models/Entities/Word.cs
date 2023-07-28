using System.ComponentModel.DataAnnotations;

namespace CopyLingo.Core.Models.Entities
{
    public class Word
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string? English { get; set; }

        [Required]
        [StringLength(255)]
        public string? Turkish { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
