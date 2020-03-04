using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.ViewModels
{
    public class ManufacturerViewModel
    {
        public int Id { get; set; }
        public string Name { get;  set; }

        public ICollection<DetailViewModel> Details { get; set; }//new   
        public ICollection<CarViewModel> Cars { get; set; }//new
    }
}
