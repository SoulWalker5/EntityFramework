using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CarContext : DbContext
    {
        public CarContext() : base(@"Initial Catalog=CarDB;Integrated Security=True")
        {

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<DetType> DetTypes { get; set; }
    }
}
