using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Services;
using PresentationLayer.Interfaces;
using PresentationLayer.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PresentationLayer.Controllers
{
    public class ManufacturerController : IManufacturerController
    {
        IManufacturerService service = new ManufacturerService();

        public IEnumerable<ManufacturerViewModel> GetAll()
        {
            var manufacturerViewModels = service.GetAll().Select(x => new ManufacturerViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Cars = x.Cars.Select(c => new CarViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Parts = c.Parts.Select(y => new DetailViewModel
                    {
                        CarId = y.CarId,
                        Name = y.Name,
                        Price = y.Price
                    }).ToList()
                }).ToList(),
                Details = x.Details.Select(u => new DetailViewModel
                {
                    Id = u.Id,
                    CarId = u.CarId,
                    Name = u.Name,
                    Price = u.Price
                }).ToList()
            }).ToList();

            return manufacturerViewModels;
        }
        public IEnumerable<CarManufacturerViewModel> GetCarManufacturerModels()
        {
            var allcarManufacturerModel = service.GetAll();

            var carManufacturerModel = allcarManufacturerModel.Select(x => new CarManufacturerViewModel
            {
                Manufacturer = new ManufacturerViewModel
                {
                    Name = x.Name,
                    Id = x.Id
                },
                MostExpensiveCar = x.Cars.OrderBy(y => y.Parts.Sum(c => c.Price)).Select(y => new CarViewModel
                {
                    Name = y.Name,
                    Id = y.Id,
                }).FirstOrDefault()
            }).ToList();
            return carManufacturerModel;
        }
    }
}
