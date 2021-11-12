using BekeTanszekBistro.MenuBoard.Api.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BekeTanszekBistro.MenuBoard.Api.Persistence.EntityConfigurations
{
    public class MealConfiguration : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder
                .ToTable("meals");

            builder
                .Property(meal => meal.Id)
                .HasColumnName("id");

            builder
                .Property(meal => meal.Name)
                .HasColumnName("name")
                .HasMaxLength(255)
                .IsRequired();

            builder
                .Property(meal => meal.Price)
                .HasColumnName("price")
                .IsRequired();

            builder
                .Property(meal => meal.TypeId)
                .HasColumnName("type_id");
        }
    }
}
