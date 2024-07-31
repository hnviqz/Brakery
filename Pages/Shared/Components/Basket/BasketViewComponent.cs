using Brakery.Models;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
namespace Brakery.Pages.Components.Basket;


public class BasketViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        Brakery.Models.Basket basket = new();
        if(Request.Cookies[nameof(Brakery.Models.Basket)] is not null)
        {
            basket = JsonSerializer.Deserialize<Brakery.Models.Basket>(Request.Cookies[nameof(Brakery.Models.Basket)]);
        }
        
        return View(basket);
    }
}
