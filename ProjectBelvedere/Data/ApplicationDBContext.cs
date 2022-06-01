using Microsoft.EntityFrameworkCore;
using BelvedereServices.Models;

namespace BelvedereServices.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<ServiceOrder> ServiceOrders { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {

        }
    }
}
