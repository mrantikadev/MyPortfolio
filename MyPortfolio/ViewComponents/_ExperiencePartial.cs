using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ExperiencePartial : ViewComponent
    {
        private readonly AppDbContext _context;

        public _ExperiencePartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Experiences.ToList();
            return View(values);
        }
    }
}
