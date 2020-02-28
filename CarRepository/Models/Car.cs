using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public class Car
    {
        
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Detail> Parts { get; set; }

        public Car() => Parts = new List<Detail>();
    }
}
