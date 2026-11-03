using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ApplicationDbcontext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=[book inventory];Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Author> Author { get; set; }
        public DbSet<book> Books { get; set; }
        public DbSet<categories> Categories { get; set; }
    }
}
 