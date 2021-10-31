using BekeTanszekBistro.MenuBoard.Api.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BekeTanszekBistro.MenuBoard.Api.Persistence.EntityConfigurations
{
    public class DailyMenuConfiguration : IEntityTypeConfiguration<DailyMenu>
    {
        public void Configure(EntityTypeBuilder<DailyMenu> builder)
        {
            builder
                .ToTable("daily_menus");

            builder
                .Property(m => m.Id)
                .HasColumnName("id");

            builder
                .Property(m => m.MealId)
                .HasColumnName("meal_id");
        }
    }
}
