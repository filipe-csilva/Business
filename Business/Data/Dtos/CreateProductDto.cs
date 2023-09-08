namespace Business.Models
{
    public class CreateProductDto
    {
        public string? Name { get; set; }
        public string? GTIN { get; set; }
        public Group GroupID { get; set; }
        public float PricePurchase { get; set; }
        public float PriceCoast { get; set; }
        public float PriceSale { get; set; }
        public string? Description { get; set; }
    }
}
