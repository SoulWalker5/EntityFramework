﻿using BusinessLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    interface ICarManufacturerService
    {
        IEnumerable<CarManufacturerModel> GetCarManufacturerModels();
    }
}