namespace BusinessLogicLayer.Models
{
    public class DetailModel
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int DetTypeId { get; set; }//new

        public ManufacturerModel Manufacturer { get; set; }//new

        //public CarModel CarModel { get; set; }


    }
}
