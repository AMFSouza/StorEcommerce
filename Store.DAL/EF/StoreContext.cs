using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Store.DAL.EF
{
    public class StoreContext: DbContext
    {

        public StoreContext()
        {

        }

        public StoreContext(DbContextOptions options):base(options)
        {
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured) {

            }
        }
    }
}
