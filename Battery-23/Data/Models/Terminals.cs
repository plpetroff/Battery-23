namespace Battery_23.Data.Models
{
    using System.Collections.Generic;

    public class Terminal
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public IEnumerable<Battery> Batteries { get; init; } = new List<Battery>();
    }
}
