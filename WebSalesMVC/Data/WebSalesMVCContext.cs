using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebSalesMVC.Models;
using WebSalesMVC.Services;

namespace WebSalesMVC.Data
{
    public class WebSalesMVCContext : DbContext
    {
        public WebSalesMVCContext (DbContextOptions<WebSalesMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

        public static implicit operator WebSalesMVCContext(SellerService v)
        {
            throw new NotImplementedException();
        }
    }
}
