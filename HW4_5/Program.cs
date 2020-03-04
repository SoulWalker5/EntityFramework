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

            var det = detailController.GetDetails();
            var vehicles = carsController.GetСars();

            var carViewModel = new CarViewModel()
            {
                Id = 6,
                Name = "PAZIK",

            };

            var hz = detailController.GetDetails();

            var getmanufacturer = manufacturerController.GetAll();

            var getall = manufacturerController.GetCarManufacturerModels();

        }
    }
}
