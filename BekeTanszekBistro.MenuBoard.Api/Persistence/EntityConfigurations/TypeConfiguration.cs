using BekeTanszekBistro.MenuBoard.Api.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BekeTanszekBistro.MenuBoard.Api.Persistence.EntityConfigurations
{
    public class TypeConfiguration : IEntityTypeConfiguration<Type>
    {
        public void Configure(EntityTypeBuilder<Type> builder)
        {
            builder
                .ToTable("types");

            builder
                .Property(t => t.Id)
                .HasColumnName("id");

            builder
                .Property(t => t.Name)
                .HasColumnName("name")
                .HasMaxLength(255)
                .IsRequired();
        }
    }
}
