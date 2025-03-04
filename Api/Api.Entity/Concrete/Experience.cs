using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.EntityLayer.Concrete
{
    public class Experience
    {
        public int ExperienceId { get; set; }

        [Required]
        public string Head { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Date { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
