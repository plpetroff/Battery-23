namespace Battery_23.Models.Batteries
{
    using Battery_23.Data.Models;
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Linq;

    public class AddBatteryFormModel
    {
        [Display(Name = "Brand of the Battery")]
        public int BrandId { get; init; }
        public Brand Brand { get; init; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int TechnologyId { get; set; }
        public Technology Technology { get; set; }

        public int CapacityId { get; set; }
        public Capacity Capacity { get; set; }

        public int TerminalId { get; set; }
        public Terminal Terminal { get; set; }

        public int BoxTypeId { get; set; }
        public BoxType BoxType { get; set; }
    }
}
