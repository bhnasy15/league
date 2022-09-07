namespace Domains.Team
{
    using Common;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TeamConfiguration : BaseEntityconfiguration<Team>
    {
        public override void Configure(EntityTypeBuilder<Team> builder)
        {
			builder.HasMany(p => p.Players).WithOne().HasForeignKey(p => p.TeamId);
        }
    }
}
