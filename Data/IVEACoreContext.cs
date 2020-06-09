using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using IVEACore.Models;

namespace IVEACore.Data
{
    public class IVEACoreContext : IdentityDbContext
    {
        public IVEACoreContext()
        {
        }

        public IVEACoreContext(DbContextOptions<IVEACoreContext> options)
            : base(options)
        {
        }
        public DbSet<IVEACore.Models.Farm> Farm { get; set; }
        public DbSet<IVEACore.Models.FarmSampling> FarmSampling { get; set; }
    }
}
