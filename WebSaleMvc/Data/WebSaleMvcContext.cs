using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebSaleMvc.Models;

namespace WebSaleMvc.Data
{
    public class WebSaleMvcContext : DbContext
    {
        public WebSaleMvcContext (DbContextOptions<WebSaleMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
