namespace Business.Models
{
    public class Supplier : Person
    {
        public Supplier()
        {
            this.Brands = new List<Brand>();
        }

        public int Id { get; set; }
        public string CNPJ {  get; set; }
        public string IE { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Brand> Brands { get; set; }
    }
}
