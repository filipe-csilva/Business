namespace Business.Models
{
    public class ReadClientDto : Person
    {
        public int Id { get; set; }
        public string? CPF { get; set; }
    }
}
