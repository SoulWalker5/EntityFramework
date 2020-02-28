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

            var det = detailController.GetDetails();
            var vehicles = carsController.GetСars();


            
            var hz = detailController.GetById(1);

            //var carViewModel = new CarViewModel()
            //{
            //    Id = 1,
            //    Name = "Huyndai",
            //    //Parts = new List<DetailViewModel> {
            //    //new DetailViewModel()
            //    //{
            //    //    CarId = 3,
            //    //    Name = "Seat",
            //    //    Price = 400
            //    //}}
            //};
            //carsController.Update(carViewModel);


            //carsController.Create(carViewModel);

            //var detViewModel = new DetailViewModel()
            //{
            //    //Id = 3,
            //    Name = "Seat",
            //    Price = 150,
            //    CarId = 2
            //    //Parts = new List<DetailViewModel> {
            //    //new DetailViewModel()
            //    //{
            //    //    CarId = 3,
            //    //    Name = "Seat",
            //    //    Price = 400
            //    //}}
            //};
            //detailController.Create(detViewModel);
        }
    }
}
