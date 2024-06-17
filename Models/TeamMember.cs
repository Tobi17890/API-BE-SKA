namespace MyApiProject.Models
{
    public class TeamMember
    {
        public required string Name { get; set; }
        public required string Gender { get; set; }
        public required int Age { get; set; }
        public required string Address { get; set; }
        public required string Email { get; set; }
    }
}