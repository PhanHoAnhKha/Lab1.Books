using System.ComponentModel.DataAnnotations;

namespace RESR_API_TEMPLATE.Models
{
    public class Author
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public List<Book>? Books { get; set; }
    }
}
