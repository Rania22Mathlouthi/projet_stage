using Microsoft.EntityFrameworkCore;
using projet_stage.models;

namespace projet_stage.Data
{
    public class ModelDbContext : DbContext
    {
        public ModelDbContext(DbContextOptions<ModelDbContext> options) : base(options)
        {
            //constructor

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Employee_Material_Assignment> Assignments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.Entity<Employee_Material_Assignment>()
                   .HasOne(e => e.Employee)
                   .WithMany(e => e.Assignments)
                   .HasForeignKey(e => e.Id_Employee)
                   .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Employee_Material_Assignment>()
                   .HasOne(e => e.Material)
                   .WithMany(e => e.Assignments)
                   .HasForeignKey(e => e.Id_Material)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
