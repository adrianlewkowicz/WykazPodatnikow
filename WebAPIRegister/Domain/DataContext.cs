using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;
using WykazPodatnikow.Data;

namespace WebAPIRegister.Domain
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        
        public virtual DbSet<Entity> Entities { get; set; }
       


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entity>().ToTable("Entity");
            modelBuilder.Entity<Entity>().Property(e => e.Id).IsRequired().HasColumnName("id");
            modelBuilder.Entity<Entity>().Property(e => e.Nip).IsRequired().HasColumnName("nip");
            modelBuilder.Entity<Entity>().Property(e => e.RestorationDate).IsRequired().HasColumnName("restorationdate");
         
        }

       
    }
}
