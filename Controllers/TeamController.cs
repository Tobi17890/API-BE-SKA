using Microsoft.AspNetCore.Mvc;
using MyApiProject.Models;
using MyApiProject.Services;

namespace MyApiProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    // declare clase TeamController and its inheritance from ControllerBase
    // why doing that?
    // because ControllerBase is a class that provides the basic functionality for an MVC controller.
    public class TeamController : ControllerBase
    {
        // constructor
        private readonly ITeamService _teamService;
        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        // what are we doing here?
        // we are defining a route for the action method GetTeamMembers

        [HttpGet("GetTeamMembers")]
        public ActionResult<IEnumerable<TeamMember>> GetTeamMembers()
        {
            var teamMembers = _teamService.GetTeamMembers();
            return Ok(teamMembers);
        }
    }
}