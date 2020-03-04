using PresentationLayer.ViewModels;
using System.Collections.Generic;

namespace PresentationLayer.Interfaces
{
    public interface IManufacturerController
    {
        IEnumerable<ManufacturerViewModel> GetAll();

    }
}
