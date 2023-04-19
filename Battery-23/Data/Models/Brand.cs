namespace Battery_23.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using static DataConstants;

    public class Brand
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(BrandNameMaxLength)]
        public string BrandName { get; set; }

        public IEnumerable<Battery> Batteries { get; init; } = new List<Battery>();
    }
}
