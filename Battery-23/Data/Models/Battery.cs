namespace Battery_23.Data.Models
{
    public class Battery
    {
        public int Id { get; set; }


        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int TechnologyId { get; set; }
        public Technology Technology { get; set; }

        public int CapacityId { get; set; }
        public Capacity Capacity { get; set; }



    }
}
