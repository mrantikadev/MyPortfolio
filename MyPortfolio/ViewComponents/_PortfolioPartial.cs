using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _PortfolioPartial : ViewComponent
    {
        private readonly AppDbContext _context;

        public _PortfolioPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Portfolios.ToList();
            return View(values);
        }
    }
}
