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
        IManufacturerService repository = new ManufacturerService();

        public IEnumerable<ManufacturerViewModel> GetAll()
        {
            var manufacturerViewModels = repository.GetAll().Select(x => new ManufacturerViewModel
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
    }
}
