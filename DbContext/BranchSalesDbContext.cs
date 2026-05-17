using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BranchSalesAutomation.Models;

namespace BranchSalesAutomation.DatabaseContext
{
    internal class BranchSalesDbContext : DbContext
    {
        public BranchSalesDbContext() : base("name=BranchSalesDbContext")
        {

        }

        public DbSet<Branch> Branches { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Stock> Stocks { get; set; }

        public DbSet<Sales> Sales { get; set; }
    }
} 