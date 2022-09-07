namespace Domains.Player
{
	using Common;
    using Domains.Linker;

    public class PlayerViewModel : BaseEntityViewModel
    {
		public int number { get; set; }
		public string profileImage { get; set; } = string.Empty;
		public string country { get; set; } = string.Empty;
        public DateTime dob { get; set; }

		public TeamPlayer Team { get; set; }
    }
}
