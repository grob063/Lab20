using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Lab20EFCore.GenesCoffee
{
    public class MyCoffeeContext : DbContext
    {
        public MyCoffeeContext(DbContextOptions<MyCoffeeContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }

        public DbSet<Product> Product { get; set; }
    }
}
