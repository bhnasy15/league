namespace Domains.Team
{
	using Common;
	using Domains.Player;

    public class TeamViewModel : BaseEntityViewModel
    {
		public string logo { get; set; } = string.Empty;
		public string country { get; set; } = string.Empty;
		public string coatch { get; set; } = string.Empty;
        public DateTime foundatoinDate { get; set; }
        public ICollection<Player> players { get; set; }
    }
}
