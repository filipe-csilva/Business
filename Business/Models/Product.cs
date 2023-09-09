namespace Business.Models
{
    public class Product
    {
        public Product()
        {
            this.Clients = new List<Client>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? GTIN { get; set; }
        public Group GroupID { get; set; }
        public SubGroup SubGroupID { get; set; }
        public float PricePurchase { get; set; }
        public float PriceCoast { get; set; }
        public float PriceSale { get; set; }
        public string? Description { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        public ICollection<Client> Clients { get; set; }
    }
}
