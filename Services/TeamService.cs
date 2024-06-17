using MyApiProject.Models;

namespace MyApiProject.Services
{
    public class TeamService : ITeamService
    {
        public IEnumerable<TeamMember> GetTeamMembers()
        {
            return new List<TeamMember>
            {
                new TeamMember { Name = "Tobi", Age = 22, Address = "Toul SongKae", Gender = "Male", Email = "tobi@gmail.com"},
                new TeamMember { Name = "John", Age = 25, Address = "Toul Kork", Gender = "Female", Email = "johnah@gmail.com"},
            };
        }
    }
}