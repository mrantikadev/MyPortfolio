﻿using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutSidebarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
