using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace CropsDictonary.Core
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Crop> Crops { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=crops.db");
        }
    }
}
