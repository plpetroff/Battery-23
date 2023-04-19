namespace Battery_23.Data
{
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
    }
}
