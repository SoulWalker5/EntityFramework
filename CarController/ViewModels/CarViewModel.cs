using BusinessLogicLayer.Models;
using System;
using System.Collections.Generic;

namespace PresentationLayer.ViewModels
{
    public class CarViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ManufacturerViewModel Manufacturer { get; set; }//new

        public ICollection<DetailViewModel> Parts { get; set; }

        //public IEnumerable<CarByManufacturer> CarByManufacturers { get; set; }
    }

    //public class CarByManufacturer
    //{
    //    public ManufacturerViewModel Manufacturer { get; set; }
    //    public int Price { get; set; }
    //}
}
