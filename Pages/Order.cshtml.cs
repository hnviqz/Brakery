using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Brakery.Models;
using Brakery.Data;

namespace Brakery.Pages
{
    public class OrderModel : PageModel
    {
        private readonly BrakeryContext _ctx; 

        public OrderModel(BrakeryContext ctx)=>_ctx=ctx;

        [BindProperty(SupportsGet=true)]
        public int Id{get;set;}
        public Product Product{get;set;} = new();

        [BindProperty,Range(1,int.MaxValue,ErrorMessage="You must order at least one item")]
        public int Quantity{get;set;}=1;
        [BindProperty,Required,EmailAddress,Display(Name="Your Email Address")]
        public string? OrderEmail{get;set;}
        [BindProperty,Required,Display(Name="Shipping Address")]
        public string? ShippingAddress{get;set;}

        [BindProperty]
        public decimal UnitPrice{get;set;}
        [TempData]
        public string? Confirmation{get;set;}
        public void OnGet()
        {
            Product = _ctx.Products.Find(Id)!;
        }

        public IActionResult OnPost()
        {
            Product = _ctx.Products.Find(Id);
            if(ModelState.IsValid)
            {
                Confirmation = @$"You have ordered {Quantity}X{Product.Name} at a total cost of {Quantity*UnitPrice:c}"; 
                return RedirectToPage("/OrderSuccess");
            }
            return Page();
        }
    }
}
