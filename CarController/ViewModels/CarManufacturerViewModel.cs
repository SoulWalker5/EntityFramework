﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.ViewModels
{
    public class CarManufacturerViewModel
    {
        public ManufacturerViewModel Manufacturer { get; set; }
        public CarViewModel MostExpensiveCar { get; set; }
    }
}
