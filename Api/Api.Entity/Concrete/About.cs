using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.EntityLayer.Concrete
{
    public class About
    {
        public int AboutId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string SubDescription { get; set; }

        [Required]
        public string Details { get; set; }
    }
}
