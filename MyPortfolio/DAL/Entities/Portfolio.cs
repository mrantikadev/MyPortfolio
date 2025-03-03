namespace MyPortfolio.DAL.Entities
{
    public class Portfolio
    {
        public int PortfolioId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Technology { get; set; }
        public string Url { get; set; }
    }
}
