namespace Domains.Player
{
	using Common;
    using Microsoft.EntityFrameworkCore;

    public class PlayerRepository : BaseRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
