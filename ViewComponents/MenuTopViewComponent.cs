﻿using ASP.NET_Core_MVC.Models;
using Harmic.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_MVC.ViewComponents
{
    public class MenuTopViewComponent : ViewComponent
    {
        private readonly HarmicContext _context;
        
        public MenuTopViewComponent(HarmicContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = _context.TbMenus.Where(m => (bool)m.IsActive).OrderBy(m => m.Position).ToList();
            return await Task.FromResult<IViewComponentResult>(View(items));
        }

    }
}
