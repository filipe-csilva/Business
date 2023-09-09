﻿namespace Business.Models
{
    public class SubGroup
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
