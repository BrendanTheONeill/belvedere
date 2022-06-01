using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BelvedereServices.Models;

namespace BelvedereServices.Pages.Forms
{
    public class CustomServiceModel : PageModel
    {
        [BindProperty]
        public ServicesModel Service { get; set; }
        public float ServicePrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            ServicePrice = Service.BasePrice;

            if (Service.GrassCutting) ServicePrice += 300;
            if (Service.RoofCleaning) ServicePrice += 300;
            if (Service.TreePlanting) ServicePrice += 400;
            if (Service.Powerwashing) ServicePrice += 400;
            if (Service.ClutterRemoval) ServicePrice += 400;
            if (Service.HousePainting) ServicePrice += 400;
            if (Service.PoolInstallation) ServicePrice += 500;
            if (Service.ProblemSolving) ServicePrice += 3000;

            return RedirectToPage("/Checkout/Checkout", new { Service.ServiceName, ServicePrice});
        }
    }
}
