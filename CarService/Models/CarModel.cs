using System.Collections.Generic;

namespace BusinessLogicLayer.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ManufacturerModel Manufacturer { get; set; }

        public ICollection<DetailModel> Parts { get; set; }
    }
}
