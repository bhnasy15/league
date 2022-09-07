using Common;
using Domains.Linker;

namespace Domains.Player
{
    public class Player : BaseEntity
    {
        public int number { get; set; }
        public string profileImage { get; set; } = string.Empty;
        public string country { get; set; } = string.Empty;
        public DateTime dob { get; set; }

		public TeamPlayer Team { get; set; }
    }
}
