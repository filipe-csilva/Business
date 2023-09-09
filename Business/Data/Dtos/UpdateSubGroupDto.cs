namespace Business.Models
{
    public class UpdateSubGroupDto
    {
        public int Id { get; private set; }
        public string? Name { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
