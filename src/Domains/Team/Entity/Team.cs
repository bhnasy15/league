using Common;
using Domains.Linker;

namespace Domains.Team
{
    public class Team : BaseEntity
    {
        public string logo { get; set; } = string.Empty;
        public string country { get; set; } = string.Empty;
        public string coatch { get; set; } = string.Empty;
        public DateTime foundatoinDate { get; set; }

        public ICollection<PlayerTeam> players { get; set; }
    }
}
