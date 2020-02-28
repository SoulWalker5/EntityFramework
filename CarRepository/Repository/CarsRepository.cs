using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repository
{
    public class CarsRepository : ICarsRepository
    {
        //private static readonly string connectionString = @"Initial Catalog=AutoDB;Integrated Security=True";

        private readonly CarContext _ctx;
        public CarsRepository()
        {
            _ctx = new CarContext();
        }
        public void Delete(int id)
        {
            Car car = new Car { Id = id };
            _ctx.Cars.Remove(car);
            _ctx.SaveChanges();
        }

        public IEnumerable<Car> GetCars()
        {
            var cars = _ctx.Cars.ToList();
            var details = cars.Select(x => x.Parts).ToList();
            return cars;
        }


        public void Create(Car car)
        {
            _ctx.Cars.Add(car);
            _ctx.SaveChanges();
        }

        public void Update(Car car)
        {
            var findcar = _ctx.Cars.Find(car.Id);
            findcar.Name = car.Name;
            //findcar.Parts = car.Parts;
            _ctx.SaveChanges();

            //сначала получаешь её из базы, затем изменяешь её , и сохраняешь
        }

        public Car GetById(int id)
        {
            var search = _ctx.Cars.Find(id);
            return search;
        }
    }
}
