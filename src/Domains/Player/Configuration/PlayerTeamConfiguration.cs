namespace Domains.Player
{
    using Common;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class PlayerTeamConfiguration : BaseEntityconfiguration<PlayerTeam>
    {
        public override void Configure(EntityTypeBuilder<PlayerTeam> builder)
        {
        }
    }
}
