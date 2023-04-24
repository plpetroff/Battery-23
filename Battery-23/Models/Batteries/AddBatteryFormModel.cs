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
    }
}
