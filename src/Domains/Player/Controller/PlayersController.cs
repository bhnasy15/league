
namespace Domains.Player
{
	using Common;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

	[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : BaseController<Player>
    {
        public PlayersController(IPlayerUnitOfWork playerUnitOfWork) : base(playerUnitOfWork)
        {
        }
    }
}
