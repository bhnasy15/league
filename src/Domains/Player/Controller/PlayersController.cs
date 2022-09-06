
namespace Domains.Player
{
    using AutoMapper;
    using Common;
    using FluentValidation;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : BaseController<Player, PlayerViewModel>
    {
        public PlayersController(IPlayerUnitOfWork unitOfWork, IMapper mapper, IValidator<PlayerViewModel> validator) : base(unitOfWork, mapper, validator)
        {
        }
    }
}
