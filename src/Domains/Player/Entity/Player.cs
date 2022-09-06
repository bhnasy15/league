using Common;

namespace Domains.Player
{
    public class Player : BaseEntity
    {
		public int number { get; set; }
		public string profileImage { get; set; } = string.Empty;
		public string country { get; set; } = string.Empty;
		public PlayerTeam team { get; set; }
    }
}
