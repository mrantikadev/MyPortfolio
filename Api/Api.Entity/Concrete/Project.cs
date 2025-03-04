using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.EntityLayer.Concrete
{
    public class Project
    {
        public int ProjectId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Date { get; set; }

        [Required]
        public string Technology { get; set; }
        public string Url { get; set; }
    }
}
