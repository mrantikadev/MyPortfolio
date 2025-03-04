using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.EntityLayer.Concrete
{
    public class SocialMedia
    {
        public int SocialMediaId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Url { get; set; }
        public string? Icon { get; set; } = string.Empty;
    }
}
