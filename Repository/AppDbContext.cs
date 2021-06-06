using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Repository.Configurations;
using Repository.DbModels;



namespace Repository
{
    public class AppDbContext : DbContext
    {
        

        public virtual DbSet<BuildVersionRecord> BuildVersion { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new BuildVersionConfiguration());
            
        }
    }
}
