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
                .Property(m => m.Id)
                .HasColumnName("id");

            builder
                .Property(m => m.Name)
                .HasColumnName("name")
                .HasMaxLength(255)
                .IsRequired();

            builder
                .Property(m => m.Price)
                .HasColumnName("price")
                .IsRequired();

            builder
                .Property(m => m.TypeId)
                .HasColumnName("type_id");
        }
    }
}
