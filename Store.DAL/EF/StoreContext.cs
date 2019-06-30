using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Store.Models.Entities;

namespace Store.DAL.EF
{
    public class StoreContext : DbContext
    {

        public StoreContext()
        {

        }

        public StoreContext(DbContextOptions options) : base(options) { }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer
                    (@"Server=(localdb)\mssqllocaldb;Database=EcommStore;Trusted_Connection=True;MultipleActiveResultSets=true;",
                        options=> options.EnableRetryOnFailure());
            }
        }
    }
}
