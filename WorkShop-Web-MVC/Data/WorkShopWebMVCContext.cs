using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WorkShopWebMVC.Models
{
    public class WorkShopWebMVCContext : DbContext
    {
        public WorkShopWebMVCContext (DbContextOptions<WorkShopWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<WorkShopWebMVC.Models.Department> Department { get; set; }
    }
}
