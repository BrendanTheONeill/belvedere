using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BelvedereServices.Data;
using BelvedereServices.Models;

namespace BelvedereServices.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        public string ServiceName { get; set; }
        public float ServicePrice { get; set; }
        public string ImageTitle { get; set; }
        public DateTime Datetime { get; set; }
        public bool GrassCutting { get; set; }
        public bool RoofCleaning { get; set; }
        public bool TreePlanting { get; set; }
        public bool Powerwashing { get; set; }
        public bool ClutterRemoval { get; set; }
        public bool HousePainting { get; set; }
        public bool PoolInstallation { get; set; }
        public bool ProblemSolving { get; set; }

        private readonly ApplicationDBContext _context;
        public CheckoutModel(ApplicationDBContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            if(string.IsNullOrWhiteSpace(ServiceName))
            {
                ServiceName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Belvedere Happy";
            }

            ServiceOrder serviceOrder = new ServiceOrder();
            serviceOrder.ServiceName = ServiceName;
            serviceOrder.BasePrice = ServicePrice;
            serviceOrder.Datetime = Datetime;
            serviceOrder.GrassCutting = GrassCutting;
            serviceOrder.RoofCleaning = RoofCleaning;
            serviceOrder.Powerwashing = Powerwashing;
            serviceOrder.ClutterRemoval = ClutterRemoval;
            serviceOrder.HousePainting = HousePainting;
            serviceOrder.PoolInstallation = PoolInstallation;
            serviceOrder.ProblemSolving = ProblemSolving;
            serviceOrder.TreePlanting = TreePlanting;

            _context.ServiceOrders.Add(serviceOrder);
            _context.SaveChanges();
        }
    }
}
