namespace Battery_23.Data.Models
{
    using System.Collections.Generic;

    public class Technology
    {
        public int TechnologyId { get; set; }
        public string TechnologyName { get; set; }
        public IEnumerable<Battery> Batteries { get; init; } = new List<Battery>();
    }
}
