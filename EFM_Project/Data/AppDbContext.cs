using EFM_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace EFM_Project.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quantity>().HasKey(am => new
            {
                am.Etape_id,
                am.Ingredient_id
            });

            modelBuilder.Entity<Quantity>().HasOne(m => m.Etapes).WithMany(am => am.Quantities).HasForeignKey(m => m.Ingredient_id);
            modelBuilder.Entity<Quantity>().HasOne(m => m.Ingredient).WithMany(am => am.Quantities).HasForeignKey(m => m.Etape_id);


            base.OnModelCreating(modelBuilder);
        }

        
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Etapes> Etapes { get; set; }
        public DbSet<Quantity> Quantity { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
