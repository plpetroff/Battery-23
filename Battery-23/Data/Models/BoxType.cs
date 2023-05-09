namespace Battery_23.Data.Models
{
    using System.Collections.Generic;

    public class BoxType
    {
        public int Id { get; set; }
        public string BoxTypeCode { get; set; }
        public IEnumerable<Battery> Batteries { get; init; } = new List<Battery>();
    }
}
