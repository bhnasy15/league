
namespace Domains.Team
{
	using Common;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

	[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : BaseController<Team>
    {
        public TeamsController(ITeamUnitOfWork teamUnitOfWork) : base(teamUnitOfWork)
        {
        }
    }
}
