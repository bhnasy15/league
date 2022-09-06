namespace Domains.Player
{
	using Common;
    public class PlayerViewModel : BaseEntityViewModel
    {
		public int number { get; set; }
		public string profileImage { get; set; } = string.Empty;
		public string country { get; set; } = string.Empty;
    }
}
