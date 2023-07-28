using System.ComponentModel.DataAnnotations;

namespace CopyLingo.Core.Models.Entities
{
    public class Test
    {
        [Key]
        public int TestId { get; set; }
        public string? Message { get; set; }
    }
}
