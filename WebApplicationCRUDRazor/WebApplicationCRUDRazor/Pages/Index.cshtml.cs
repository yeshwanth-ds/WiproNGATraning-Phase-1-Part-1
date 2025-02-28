using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplicationCRUDRazor.Models;

namespace WebApplicationCRUDRazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly WebApplicationCRUDRazor.Models.ProductDbContext _context;

        public IndexModel(WebApplicationCRUDRazor.Models.ProductDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
