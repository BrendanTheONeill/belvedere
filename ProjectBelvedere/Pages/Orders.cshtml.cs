using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BelvedereServices.Data;
using BelvedereServices.Models;

namespace BelvedereServices.Pages
{
    public class OrdersModel : PageModel
    {
        public List<ServiceOrder> ServiceOrders = new List<ServiceOrder>();
        private readonly ApplicationDBContext _context;
        public OrdersModel(ApplicationDBContext context)
        {
            _context = context;
        }

        public void OnGet()
        {

            ServiceOrders = _context.ServiceOrders.ToList();
        }
    }
}
