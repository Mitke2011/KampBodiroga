using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using KampBodirogaMVC.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace KampBodirogaMVC.DbContextHolder
{
    public class EFDbContext : DbContext
    {
        public DbSet<Ucesnici> Ucesnici { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}