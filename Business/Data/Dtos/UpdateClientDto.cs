namespace Business.Models
{
    public class UpdateClientDto : Person
    {
        public int Id { get; internal set; }
        public string CPF { get; set; }
    }
}
