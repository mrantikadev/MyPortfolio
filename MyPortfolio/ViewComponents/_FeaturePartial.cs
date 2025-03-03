using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _FeaturePartial : ViewComponent
    {
        private readonly AppDbContext _context;

        public _FeaturePartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Features.ToList();
            return View(values);
        }
    }
}
