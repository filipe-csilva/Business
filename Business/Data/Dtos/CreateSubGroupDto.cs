namespace Business.Models
{
    public class CreateSubGroupDto    {
        public string? Name { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
