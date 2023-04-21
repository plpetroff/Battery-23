namespace Battery_23.Infrastructure
{
    using Battery_23.Data;
    using Battery_23.Data.Models;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System.Linq;

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(
            this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();
            var data = scopedServices.ServiceProvider.GetService<BatteryDbContext>();

            data.Database.Migrate();

            SeedBrand(data);

            return app;
        }

        private static void SeedBrand(BatteryDbContext data)
        {
            if (data.Brands.Any())
            {
                return;
            }

            data.Brands.AddRange(new[]
            {
                new Brand {BrandName = "Varta"},
                new Brand {BrandName = "Bosch"},
                new Brand {BrandName = "Crons"},
                new Brand {BrandName = "Tenax"},
            });
        }

    }
}
