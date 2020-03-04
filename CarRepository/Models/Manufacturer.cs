﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Detail> Details { get; set; }//new   
        public virtual ICollection<Car> Cars { get; set; }//new
    }
}
