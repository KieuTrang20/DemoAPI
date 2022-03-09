using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_API.Model;
using Microsoft.EntityFrameworkCore;
namespace Demo_API.Context
{
    public class AppDbContext :DbContext
    {
        public DbSet<Lop> Lops { get; set; }
        public DbSet<HocSinh> HocSinhs { get; set; }    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-VHFH6QK\\LETRANG;database=Demo_API;integrated security=sspi;");
        }
    }
}
