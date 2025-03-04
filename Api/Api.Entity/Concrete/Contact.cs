using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.EntityLayer.Concrete
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
        public string? Phone { get; set; } = string.Empty;

        [Required]
        public string Email1 { get; set; }
        public string? Email2 { get; set; } = string.Empty;
    }
}
