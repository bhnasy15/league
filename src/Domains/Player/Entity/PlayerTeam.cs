namespace Domains.Player
{
    using Common;

    public class PlayerTeam : BaseEntity
    {
		public Guid playerId { get; set; }
		public Guid TeamId { get; set; }

		public List<Player> players;

    }

}
