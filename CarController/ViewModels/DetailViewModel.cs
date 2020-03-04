namespace PresentationLayer.ViewModels
{
    public class DetailViewModel
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int DetTypeId { get; set; }

        public ManufacturerViewModel Manufacturer { get; set; }//new


        //public CarViewModel Car { get; set; }
    }
}
