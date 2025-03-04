using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.EntityLayer.Concrete
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }

        [Required]
        public string NameSurname { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
        public string? ImageUrl { get; set; } = string.Empty;
    }
}
