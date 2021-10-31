using BekeTanszekBistro.MenuBoard.Api.Core.Models;
using BekeTanszekBistro.MenuBoard.Api.Persistence.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace BekeTanszekBistro.MenuBoard.Api.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<DailyMenu> DailyMenus { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Type> Types { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DailyMenuConfiguration());
            modelBuilder.ApplyConfiguration(new MealConfiguration());
            modelBuilder.ApplyConfiguration(new TypeConfiguration());
        }
    }
}
