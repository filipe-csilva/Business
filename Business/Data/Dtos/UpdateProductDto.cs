﻿namespace Business.Models
{
    public class UpdateProductDto
    {
        public int Id { get; internal set; }
        public string? Name { get; set; }
        public string? GTIN { get; set; }
        public Group GroupID { get; set; }
        public SubGroup SubGroupID { get; set; }
        public float PricePurchase { get; set; }
        public float PriceCoast { get; set; }
        public float PriceSale { get; set; }
        public string? Description { get; set; }
    }
}
