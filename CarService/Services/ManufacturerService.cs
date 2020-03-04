using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Models;
using DataAccessLayer.Interface;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicLayer.Services
{
    public class ManufacturerService : IManufacturerService
    {
        IManufacturerReposirory repository = new ManufacturerRepository();

        public IEnumerable<ManufacturerModel> GetAll()
        {

            var manufacturerModels = repository.GetAll().Select(x => new ManufacturerModel
            {
                Id = x.Id,
                Name = x.Name,
                Cars = x.Cars.Select(c => new CarModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Parts = c.Parts.Select(y => new DetailModel
                    {
                        CarId = y.CarId,
                        Name = y.Name,
                        Price = y.Price
                    }).ToList()

                }).ToList(),
                Details = x.Details.Select(u => new DetailModel
                {
                    Id = u.Id,
                    CarId = u.CarId,
                    Name = u.Name,
                    Price = u.Price
                }).ToList()
            }).ToList();

            return manufacturerModels;
        }
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
