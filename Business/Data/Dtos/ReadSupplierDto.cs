namespace Business.Models
{
    public class ReadSupplierDto : Person
    {
        public int Id { get; set; }
        public string CNPJ {  get; set; }
        public string IE { get; set; }
    }
}
