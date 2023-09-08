namespace Business.Models
{
    public class UpdateSupplierDto : Person
    {
        public int Id { get; internal set; }
        public string CNPJ {  get; set; }
        public string IE { get; set; }
    }
}
