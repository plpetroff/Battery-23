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
        public DbSet<Brand> Brands { get; init; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.
                Entity<Battery>()
                .HasOne(b => b.Brand)
                .WithMany(b =>b.Batteries)
                .HasForeignKey(b => b.BrandId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }

    }
}
