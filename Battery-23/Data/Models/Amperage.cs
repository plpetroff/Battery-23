namespace Battery_23.Data.Models
{
    using System.Collections;
    using System.Collections.Generic;

    public class Amperage
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public IEnumerable<Battery> Batteries { get; init; } = new List<Battery>();
    }
}
