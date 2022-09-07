namespace Domains.Team
{
    using Common;
    using Domains.Linker;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TeamConfiguration : BaseEntityconfiguration<Team>
    {
        public override void Configure(EntityTypeBuilder<Team> builder)
        {
			builder.HasMany<PlayerTeam>(t => t.players);
        }
    }
}
