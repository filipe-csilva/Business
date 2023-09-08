namespace Business.Models
{
    public class Client : Person
    {
        public Client()
        {
            this.Products = new List<Product>();
        }

        public int Id { get; set; }
        public string? CPF { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
