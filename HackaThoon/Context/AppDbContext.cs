using HackaThoon.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackaThoon.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Overview> Overviews { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Company_Language> Company_Languages { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Review> Reviews { get; set; }

    }
    

        
}
