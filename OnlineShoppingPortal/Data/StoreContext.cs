using Microsoft.EntityFrameworkCore;
using OnlineShoppingPortal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShoppingPortal.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext( DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> products { get; set; }

    }
}
