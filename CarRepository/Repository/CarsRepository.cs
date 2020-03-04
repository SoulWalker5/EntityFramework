using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repository
{
    public class CarsRepository : ICarsRepository
    {
        private readonly CarContext _ctx;
        public CarsRepository()
        {
            _ctx = new CarContext();
        }
        public void Delete(int id)
        {
            var car = _ctx.Cars.FirstOrDefault(x => x.Id == id);
            _ctx.Cars.Remove(car);
            _ctx.SaveChanges();
        }

        public IEnumerable<Car> GetCars()
        {
            var cars = _ctx.Cars.ToList();
            return cars;
        }

        public void Create(Car car)
        {
            var existingCar = GetByName(car.Name);

            if (existingCar == null)
                throw new Exception("This name is already using!");

            _ctx.Cars.Add(car);
            _ctx.SaveChanges();

        }

        public void Update(Car car)
        {
            var findcar = _ctx.Cars.Find(car.Id);
            findcar.Name = car.Name;
            //findcar.Parts = car.Parts;
            _ctx.SaveChanges();
        }

        public Car GetById(int id)
        {
            var search = _ctx.Cars.Find(id);
            return search;
        }

        public Car GetByName(string name)
        {
            var searchresult = _ctx.Cars.FirstOrDefault(x => x.Name == name);

            return searchresult;
        }
    }
}
