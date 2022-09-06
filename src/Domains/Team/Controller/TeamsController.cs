namespace Domains.Team
{
    using AutoMapper;
    using Common;
    using FluentValidation;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : BaseController<Team, TeamViewModel>
    {
        public TeamsController(ITeamUnitOfWork unitOfWork, IMapper mapper, IValidator<TeamViewModel> validator) : base(unitOfWork, mapper, validator)
        {
        }
    }
}
