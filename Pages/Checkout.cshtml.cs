using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Brakery.Data;
using Brakery.Models;
/* using System.Net;
using System.Net.Mail;
using System.Net.Mime; */
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace Brakery.Pages
{
    public class CheckoutModel : PageModel
    {
        private readonly BrakeryContext _ctx;
        public Brakery.Models.Basket Basket { get; set; } = new();
        public List<Product> SelectedProducts { get; set; } = new();

        [BindProperty, Required, EmailAddress,Display(Name = "Your Email Address")]
        public string? Email { get; set; }
        [BindProperty,Required,Display(Name="Address")]
        public string? Address { get; set; }
        [TempData]
        public string? Confirmation { get; set; }

        public CheckoutModel(BrakeryContext ctx) => _ctx = ctx;
        public void OnGet()
        {
            if (Request.Cookies[nameof(Brakery.Models.Basket)] is not null)
            {
                Basket = JsonSerializer.Deserialize<Brakery.Models.Basket>(Request.Cookies[nameof(Brakery.Models.Basket)]);
                if (Basket.NumberOfItems > 0)
                {
                    var selectedProducts = Basket.Items.Select(b => b.ProductId).ToArray();
                    SelectedProducts = _ctx.Products.Where(p => selectedProducts.Contains(p.Id)).ToList();
                }
            }
        }

        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid&&Request.Cookies[nameof(Brakery.Models.Basket)] is not null)
            {
                var basket = JsonSerializer.Deserialize<Brakery.Models.Basket>(Request.Cookies[nameof(Brakery.Models.Basket)]);
                if(basket is not null)
                {
                    var plural = basket.NumberOfItems == 1 ? string.Empty : "s";
                    Confirmation =  $@"<p>Your order for {basket.NumberOfItems} item {plural} has been received and is being proccessd:</p>
                    <p>It will be sent to {Address}. We will notify you when it has been despatched</p>";
                    var message = new MimeMessage();
                    message.From.Add(MailboxAddress.Parse("test@test.com"));
                    message.To.Add(MailboxAddress.Parse(Email));
                    message.Subject = "Your order confirmation";
                    message.Body = new TextPart("html")
                    {
                        Text = Confirmation
                    };

                    using var client = new SmtpClient();
                    await client.ConnectAsync("localhost");
                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                    Response.Cookies.Append(nameof(Brakery.Models.Basket),string.Empty,new CookieOptions{
                        Expires = DateTime.Now.AddDays(-1)
                    });

                    return RedirectToPage("OrderSuccess");
                }

               
            }
             return Page();
        }
    }
}
