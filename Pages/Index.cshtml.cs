using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Brakery.Models;
using Brakery.Data;

namespace Brakery.Pages;


public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly BrakeryContext _ctx;
    public List<Product> Products {get;set;}=new();

    public IndexModel(ILogger<IndexModel> logger,BrakeryContext ctx)
    {
        _logger = logger;
        _ctx = ctx;
    }
    public void OnGet()
    {
        Products = _ctx.Products.ToList();
        //return Products;
    }

    //public async Task OnGetAsync()=>Products= await _ctx.Products.ToListAsync();
}
