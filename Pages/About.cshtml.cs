using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bakery.Pages
{
    public class AboutModel : PageModel
    {
        public string? TimeOfDay {get;set;}
        public void OnGet()
        {
            TimeOfDay = "Evening";
            if(DateTime.Now.Hour < 18)
            {
                TimeOfDay = "Afternoon";
            }
            if(DateTime.Now.Hour < 12)
            {
                TimeOfDay = "Morning";
            }
        }
    }
}
