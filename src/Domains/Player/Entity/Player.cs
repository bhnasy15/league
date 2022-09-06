using Common;

namespace Domains.Player
{
    public class Player : BaseEntity
    {
        public Guid TeamId { get; set; }
        public int number { get; set; }
        public string profileImage { get; set; } = string.Empty;
        public string country { get; set; } = string.Empty;
        public DateTime dob { get; set; }
    }
}
