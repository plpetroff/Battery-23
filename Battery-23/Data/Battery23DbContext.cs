namespace Battery_23.Data
{
    using Battery_23.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BatteryDbContext : IdentityDbContext
    {

        public BatteryDbContext(DbContextOptions<BatteryDbContext> options)
            : base(options)
        {
        }

        public DbSet<Battery> Batteries { get; init; }
        public DbSet<Capacity> Capacities { get; init; }
        public DbSet<Brand> Brands { get; init; }
        public DbSet<Category> Categories { get; init; }
        public DbSet<Technology> Technologies { get; init; }
        public DbSet<Amperage> Amperages { get; init; }
        public DbSet<BoxType> BoxTypes { get; init; }
        public DbSet<Terminal> Terminals { get; init; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Battery>()
                .HasOne(b => b.Brand)
                .WithMany(b => b.Batteries)
                .HasForeignKey(b => b.BrandId)
                .OnDelete(DeleteBehavior.Restrict); 

            builder
                .Entity<Battery>()
                .HasOne(b => b.Capacity)
                .WithMany(c => c.Batteries)
                .HasForeignKey(b => b.CapacityId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Battery>()
                .HasOne(b => b.Category)
                .WithMany(c => c.Batteries)
                .HasForeignKey(b => b.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Battery>()
                .HasOne(b => b.Technology)
                .WithMany(t => t.Batteries)
                .HasForeignKey(b => b.TechnologyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Battery>()
                .HasOne(b => b.Terminal)
                .WithMany(t => t.Batteries)
                .HasForeignKey(b => b.TerminalId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Battery>()
                .HasOne(b => b.BoxType)
                .WithMany(bt => bt.Batteries)
                .HasForeignKey(b => b.BoxTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Battery>()
                .HasOne(b => b.Terminal)
                .WithMany(t => t.Batteries)
                .HasForeignKey(b => b.TerminalId)
                .OnDelete(DeleteBehavior.Restrict);


            base.OnModelCreating(builder);
        }

    }
}
