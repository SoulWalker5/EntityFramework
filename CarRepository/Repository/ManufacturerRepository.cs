using DataAccessLayer.Interface;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class ManufacturerRepository : IManufacturerReposirory
    {
        private readonly CarContext _ctx;

        public ManufacturerRepository() => _ctx = new CarContext();
        public IEnumerable<Manufacturer> GetAll()
        {
            var manufacturer = _ctx.Manufacturers.ToList();
            return manufacturer;
        }
    }
}
