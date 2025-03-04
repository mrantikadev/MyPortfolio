using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.EntityLayer.Concrete
{
    public class Feature
    {
        public int FeatureId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
