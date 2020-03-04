using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Models;
using DataAccessLayer.Interface;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicLayer.Services
{
    public class CarManufacturerService : ICarManufacturerService
    {
        IManufacturerReposirory repository = new ManufacturerRepository();
        public IEnumerable<CarManufacturerModel> GetCarManufacturerModels()
        {
            var allcarManufacturerModel = repository.GetAll();

            var carManufacturerModel = allcarManufacturerModel.Select(x => new CarManufacturerModel
            {
                Manufacturer = new ManufacturerModel
                {
                    Name = x.Name,
                    Id = x.Id
                },
                MostExpensiveCar = x.Cars.OrderBy(y => y.Parts.Sum(c => c.Price)).Select(y => new CarModel
                {
                    Name = y.Name,
                    Id = y.Id,
                }).FirstOrDefault()
            }).ToList();
            return carManufacturerModel;

        }
    }
}
