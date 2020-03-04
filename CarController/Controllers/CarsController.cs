using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Models;
using BusinessLogicLayer.Services;
using PresentationLayer.Interfaces;
using PresentationLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PresentationLayer.Controllers
{
    public class CarsController : ICarsController
    {
        ICarsService service = new CarsService();

        public void Create(CarViewModel carViewModel)
        {
            var isCarNameValid = IsCarNameValid(carViewModel.Name);

            if (isCarNameValid == false)
                throw new Exception("Your car name has more than 2 space correct this.");

            CarModel carModel = new CarModel
            {
                Name = carViewModel.Name,
                Parts = carViewModel.Parts.Select(x => new DetailModel { CarId = x.CarId, Name = x.Name, Price = x.Price }).ToList()
            };
            service.Create(carModel);
        }

        public void Delete(int id)
        {
            service.Delete(id);
        }

        public CarViewModel GetById(int id)
        {
            CarModel carModel = service.GetById(id);

            var carViewModel = new CarViewModel()
            {
                Id = carModel.Id,
                Name = carModel.Name,
                Parts = carModel.Parts.Select(u => new DetailViewModel
                {
                    Id = u.Id,
                    CarId = u.CarId,
                    Name = u.Name,
                    Price = u.Price
                }).ToList()
            };
            return carViewModel;
        }

        public IEnumerable<CarViewModel> GetСars()
        {
            var carsViewModel = service.GetCars().Select(x => new CarViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Parts = x.Parts.Select(u => new DetailViewModel
                {
                    Id = u.Id,
                    CarId = u.CarId,
                    Name = u.Name,
                    Price = u.Price
                }).ToList()
            });
            return carsViewModel;
        }

        public void Update(CarViewModel carViewModel)
        {
            CarModel carModel = new CarModel
            {
                Id = carViewModel.Id,
                Name = carViewModel.Name,
                //Parts = carViewModel.Parts.Select(x => new DetailModel
                //{
                //    Name = x.Name,
                //    Price = x.Price,
                //    CarId = x.CarId
                //}).ToList()

            };
            service.Update(carModel);
        }

        public bool IsCarNameValid(string carname)
        {
            string[] array;
            string name = carname;
            array = name.Split(' ');

            if (array.Length > 2)
                return false;
            return true;
        }
    }
}
