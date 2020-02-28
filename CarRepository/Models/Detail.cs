using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public class Detail
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public virtual Car Car { get; set; }
    }
}
