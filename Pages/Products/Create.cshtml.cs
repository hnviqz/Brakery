using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using Brakery.Data;
using Brakery.Models;

namespace Brakery.Pages_Products
{
    public class CreateModel : PageModel
    {
        private readonly Brakery.Data.BrakeryContext _context;
        private readonly IWebHostEnvironment _environment;
        [BindProperty,Display(Name="Product Image")]
        public IFormFile ProductImage{get;set;}

        public CreateModel(Brakery.Data.BrakeryContext context,IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            ModelState.Remove("Product.ImageName");
            if (!ModelState.IsValid||_context.Products==null||Product==null)
            {
                return Page();
            }

            Product.ImageName = ProductImage.FileName;
            var imageFile = Path.Combine(_environment.WebRootPath,"images","Products",ProductImage.FileName);
            using var fs = new FileStream(imageFile,FileMode.Create);
            await ProductImage.CopyToAsync(fs);

            
            _context.Products.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
