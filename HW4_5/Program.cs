using BusinessLogicLayer.Models;
using BusinessLogicLayer.Services;
using PresentationLayer.Controllers;
using PresentationLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson4_4
{

    class Program
    {
        static void Main(string[] args)
        {
            var detailController = new DetailsController();
            var carsController = new CarsController();
            var manufacturerController = new ManufacturerController();
            var manufacturer = new CarManufacturerService();

            var det = detailController.GetDetails();
            var vehicles = carsController.GetСars();

            var carViewModel = new CarViewModel()
            {
                Id = 6,
                Name = "PAZIK",
                //    Parts = new List<DetailViewModel> {
                //    new DetailViewModel()
                //    {
                //        CarId = 6,
                //        Name = "Wheel",
                //        Price = 100
                //    },
                //    new DetailViewModel()
                //    {
                //        CarId = 6,
                //        Name = "Seat",
                //        Price = 100
                //    }}
            };
            //carsController.Create(carViewModel);

            var hz = detailController.GetDetails();

            var getmanufacturer = manufacturerController.GetAll();

            var getall = manufacturer.GetCarManufacturerModels();

        }
    }
}
