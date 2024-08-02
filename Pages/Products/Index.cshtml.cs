using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Brakery.Data;
using Brakery.Models;

namespace Brakery.Pages_Products
{
    public class IndexModel : PageModel
    {
        private readonly Brakery.Data.BrakeryContext _context;

        public IndexModel(Brakery.Data.BrakeryContext context)
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
