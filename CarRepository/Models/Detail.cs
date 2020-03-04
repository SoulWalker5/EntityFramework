using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public class Detail
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public int ManufacturerId { get; set; }//new
        public int DetTypeId { get; set; } // new

        public Manufacturer Manufacturer { get; set; }// new
        public DetType DetType { get; set; }//new
        public virtual Car Car { get; set; }
    }
}
