using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class DetType
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public ICollection<Detail> DetailsType { get; set; }
    }
}
