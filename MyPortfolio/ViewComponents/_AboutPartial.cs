using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _AboutPartial : ViewComponent
    {
        private readonly AppDbContext _context;

        public _AboutPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Abouts.ToList();
            return View(values);
        }
    }
}
