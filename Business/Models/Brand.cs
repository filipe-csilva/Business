namespace Business.Models
{
    public class Brand
    {
        public Brand()
        {
            this.Suppliers = new List<Supplier>();   
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Supplier> Suppliers { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
