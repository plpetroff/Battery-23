namespace Battery_23.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static DataConstants;

    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryNameMaxLength)]
        public string CategoryName { get; set; }
        public IEnumerable<Battery> Batteries { get; init; } = new List<Battery>();
    }
}
