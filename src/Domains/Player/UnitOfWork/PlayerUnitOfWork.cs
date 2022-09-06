namespace Domains.Player
{
	using Common;
    public class PlayerUnitOfWork : BaseUnitOfWork<Player>, IPlayerUnitOfWork
    {
        public PlayerUnitOfWork(IPlayerRepository playerRepository) : base(playerRepository)
        {
        }
    }
}
