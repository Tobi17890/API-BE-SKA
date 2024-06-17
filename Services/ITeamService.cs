namespace MyApiProject.Models
{
    public interface ITeamService
    {
        IEnumerable<TeamMember> GetTeamMembers();
    }
}