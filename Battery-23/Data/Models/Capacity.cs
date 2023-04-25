namespace Battery_23.Data.Models
{
    using System.Collections;
    using System.Collections.Generic;

    public class Capacity
    {
        public int Id { get; set; }
        public int Value { get; set; }

        public IEnumerable<Battery> Batteries { get; set; } = new List<Battery>();
    }
}
