using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BasicMVC.Models
{
    public class BasicMVCContext : DbContext
    {
        public BasicMVCContext (DbContextOptions<BasicMVCContext> options)
            : base(options)
        {
        }

        public DbSet<BasicMVC.Models.Movie> Movie { get; set; }
    }
}
