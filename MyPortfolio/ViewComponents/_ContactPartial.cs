using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ContactPartial : ViewComponent
    {
        private readonly AppDbContext _context;

        public _ContactPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Contacts.ToList();
            return View(values);
        }
    }
}
