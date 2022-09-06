using Common;

namespace Domains.Team
{
    public class Team : BaseEntity
    {
		public string? logo { get; set; }
		public string? country { get; set; }
		public string? coatch { get; set; }
		public DateTime foundatoinDate { get; set; }
    }
}
