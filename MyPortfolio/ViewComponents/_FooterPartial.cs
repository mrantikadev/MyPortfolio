using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _FooterPartial : ViewComponent
    {
        private readonly AppDbContext _context;

        public _FooterPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.SocialMedias.ToList();
            return View(values);
        }
    }
}
