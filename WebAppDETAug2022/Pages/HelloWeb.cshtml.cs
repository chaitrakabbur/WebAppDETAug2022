using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppDETAug2022.Pages
{
    public class HelloWebModel : PageModel
    {

        public string Message { get; set; }
        public string Discount { get; set; }
        //HTTPGET
        public void OnGet()
        {
            Message = "ASP.NET is Amazing";
            Discount = "Discount is upto 15%";
        }
    }
}
