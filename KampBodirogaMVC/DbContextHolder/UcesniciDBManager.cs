using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KampBodirogaMVC.Models;

namespace KampBodirogaMVC.DbContextHolder
{
    public class UcesniciDBManager
    {
        private EFDbContext context = new EFDbContext();

        public IQueryable PrikaziUcesnike() 
        {
            return this.context.Ucesnici;
        }
    }
}
