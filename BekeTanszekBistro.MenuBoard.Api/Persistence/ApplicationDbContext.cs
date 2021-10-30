﻿using BekeTanszekBistro.MenuBoard.Api.Core.Models;
using BekeTanszekBistro.MenuBoard.Api.Persistence.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace BekeTanszekBistro.MenuBoard.Api.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Type> Types { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TypeConfiguration());
        }
    }
}
