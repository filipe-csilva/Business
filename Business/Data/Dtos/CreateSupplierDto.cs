namespace Business.Models
{
    public class CreateSupplierDto : Person
    {
        public string CNPJ {  get; set; }
        public string IE {  get; set; }
    }
}
