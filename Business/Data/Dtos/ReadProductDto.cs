namespace Business.Models
{
    public class ReadProductDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? GTIN { get; set; }
        public int GroupID { get; set; }
        public Group Group { get; set; }
        public int SubGroupID { get; set; }
        public SubGroup SubGroup { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public float PricePurchase { get; set; }
        public float PriceCoast { get; set; }
        public float PriceSale { get; set; }
        public string? Description { get; set; }
    }
}
